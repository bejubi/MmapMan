namespace WorkflowConsoleApplication1.Samples
{
    using System.Activities;

    public class SimpleXmlSampleHandler
    {
        public static void Start()
        {
            var instance = new WorkflowApplication(new SimpleXmlSample());
            instance.Run();
        }
    }
}
