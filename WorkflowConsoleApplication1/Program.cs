using System;

namespace WorkflowConsoleApplication1
{
    using WorkflowConsoleApplication1.Samples;

    class Program
    {
        static void Main(string[] args)
        {
            Guid instanceId;
            if (Guid.TryParse(args[0], out instanceId))
            {
                Workflow1Handler.Start(instanceId);
            }
            else switch (args[0])
            {
                case "WhileLoopSample":
                    WhileLoopSampleHandler.Start();
                    break;
                case "PowershellSample":
                PowershellSampleHandler.Start();
                    break;
                case "ContainerSample":
                    ContainerSampleHandler.Start();
                    break;
                case "SimpleXmlSample":
                    SimpleXmlSampleHandler.Start();
                    break;
                case "AssemblySample":
                    AssemblySampleHandler.Start();
                    break; 
            }

            Console.ReadKey();
        }
    }
}
