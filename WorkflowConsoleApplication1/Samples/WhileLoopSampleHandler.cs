namespace WorkflowConsoleApplication1.Samples
{
    using System.Activities;

    public class WhileLoopSampleHandler
    {
        public static void Start()
        {
            var instance = new WorkflowApplication(new WhileLoopSample());
            instance.Run();
        }
    }
}
