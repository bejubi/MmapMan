using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Activities;

namespace WorkflowConsoleApplication1.Samples
{
    public class AssemblySampleHandler
    {
        public static void Start()
        {
            var instance = new WorkflowApplication(new AssemblySample());
            instance.Run();
        }

    }
}
