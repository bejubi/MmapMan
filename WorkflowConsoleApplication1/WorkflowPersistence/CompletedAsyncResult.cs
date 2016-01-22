namespace WorkflowConsoleApplication1.WorkflowPersistence
{
    using System;

    /// <summary>
    /// An AsyncResult that completes as soon as it is instantiated.
    /// </summary>
    class CompletedAsyncResult : AsyncResult
    {
        public CompletedAsyncResult(AsyncCallback callback, object state)
            : base(callback, state)
        {
            this.Complete(true);
        }

        public static void End(IAsyncResult result)
        {
            End<CompletedAsyncResult>(result);
        }
    }

    class CompletedAsyncResult<T> : AsyncResult
    {
        T data;

        public CompletedAsyncResult(T data, AsyncCallback callback, object state)
            : base(callback, state)
        {
            this.data = data;
            this.Complete(true);
        }

        public static T End(IAsyncResult result)
        {
            var completedResult = End<CompletedAsyncResult<T>>(result);
            return completedResult.data;
        }
    }
}
