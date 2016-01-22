namespace WorkflowConsoleApplication1.WorkflowPersistence
{
    using System;
    using System.Reflection;
    using System.Runtime.InteropServices;
    using System.Threading;

    abstract class AsyncResult : IAsyncResult
    {
        static AsyncCallback asyncCompletionWrapperCallback;
        readonly AsyncCallback callback;

        bool endCalled;
        Exception exception;

        ManualResetEvent manualResetEvent;
        AsyncCompletion nextAsyncCompletion;
        readonly object state;
        readonly object thisLock;

        protected AsyncResult(AsyncCallback callback, object state)
        {
            this.callback = callback;
            this.state = state;
            this.thisLock = new object();
        }

        public object AsyncState
        {
            get { return this.state; }
        }

        public WaitHandle AsyncWaitHandle
        {
            get
            {
                if (this.manualResetEvent != null)
                    return this.manualResetEvent;

                lock (this.ThisLock)
                {
                    if (this.manualResetEvent == null)
                        this.manualResetEvent = new ManualResetEvent(this.IsCompleted);
                }

                return this.manualResetEvent;
            }
        }

        public bool CompletedSynchronously { get; private set; }

        public bool HasCallback
        {
            get { return this.callback != null; }
        }

        public bool IsCompleted { get; private set; }

        object ThisLock
        {
            get { return this.thisLock; }
        }

        protected void Complete(bool completedSynchronously)
        {
            if (this.IsCompleted)
            {
                // It's a bug to call Complete twice.
                throw new InvalidProgramException();
            }

            this.CompletedSynchronously = completedSynchronously;

            if (completedSynchronously)
            {
                // If we completedSynchronously, then there's no chance that the manualResetEvent was created so
                // we don't need to worry about a race
                this.IsCompleted = true;
            }
            else
            {
                lock (this.ThisLock)
                {
                    this.IsCompleted = true;
                    if (this.manualResetEvent != null)
                    {
                        this.manualResetEvent.Set();
                    }
                }
            }

            if (this.callback == null) return;

            try
            {
                this.callback(this);
            }
            catch (Exception e)
            {
                throw new InvalidProgramException("Async asyncCompletion threw an Exception", e);
            }
        }

        protected void Complete(bool completedSynchronously, Exception completeException)
        {
            this.exception = completeException;
            this.Complete(completedSynchronously);
        }

        static void AsyncCompletionWrapperCallback(IAsyncResult result)
        {
            if (result.CompletedSynchronously)
            {
                return;
            }

            var thisPtr = (AsyncResult)result.AsyncState;
            var callback = thisPtr.GetNextCompletion();

            bool completeSelf;
            Exception completionException = null;
            try
            {
                completeSelf = callback(result);
            }
            catch (Exception e)
            {
                if (IsFatal(e)) throw;

                completeSelf = true;
                completionException = e;
            }

            if (completeSelf)
            {
                thisPtr.Complete(false, completionException);
            }
        }

        public static bool IsFatal(Exception exception)
        {
            while (exception != null)
            {
                if ((exception is OutOfMemoryException && !(exception is InsufficientMemoryException)) ||
                    exception is ThreadAbortException ||
                    exception is AccessViolationException ||
                    exception is SEHException)
                {
                    return true;
                }

                // These exceptions aren't themselves fatal, but since the CLR uses them to wrap other exceptions,
                // we want to check to see whether they've been used to wrap a fatal completeException.  If so, then they
                // count as fatal.
                if (exception is TypeInitializationException ||
                    exception is TargetInvocationException)
                {
                    exception = exception.InnerException;
                }
                else
                {
                    break;
                }
            }

            return false;
        }

        protected AsyncCallback PrepareAsyncCompletion(AsyncCompletion asyncCompletion)
        {
            this.nextAsyncCompletion = asyncCompletion;
            return asyncCompletionWrapperCallback ?? (asyncCompletionWrapperCallback = AsyncCompletionWrapperCallback);
        }

        AsyncCompletion GetNextCompletion()
        {
            var result = this.nextAsyncCompletion;
            this.nextAsyncCompletion = null;
            return result;
        }

        protected static TAsyncResult End<TAsyncResult>(IAsyncResult result)
            where TAsyncResult : AsyncResult
        {
            if (result == null)
            {
                throw new ArgumentNullException("result");
            }

            var asyncResult = result as TAsyncResult;

            if (asyncResult == null)
                throw new ArgumentException("Invalid AsyncResult", "result");

            if (asyncResult.endCalled)
                throw new InvalidOperationException("AsyncResult already ended");

            asyncResult.endCalled = true;

            if (!asyncResult.IsCompleted)
                asyncResult.AsyncWaitHandle.WaitOne();

            if (asyncResult.manualResetEvent != null)
                asyncResult.manualResetEvent.Close();

            if (asyncResult.exception != null)
                throw asyncResult.exception;

            return asyncResult;
        }

        // can be utilized by subclasses to write core completion code for both the sync and async paths
        // in one location, signaling chainable synchronous completion with the boolean result,
        // and leveraging PrepareAsyncCompletion for conversion to an AsyncCallback.
        // NOTE: requires that "this" is passed in as the state object to the asynchronous sub-call being used with a completion routine.
        protected delegate bool AsyncCompletion(IAsyncResult result);
    }
}
