﻿namespace WorkflowConsoleApplication1.Samples
{
    using System.Activities;

    public class ContainerSampleHandler
    {
        public static void Start()
        {
            var instance = new WorkflowApplication(new ContainerSample());
            instance.Run();
        }
    }
}
