using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Activities;
using System.IO;

namespace WorkflowConsoleApplication1.Samples
{
    public class FileExists : CodeActivity
    {
        public InArgument<string> StepID { get; set; }
        public InArgument<string> AutomationExtension { get; set; }

        public OutArgument<bool> AutomationFileExists { get; set; }

        protected override void Execute(CodeActivityContext context)
        {

            string automationFileName = null;
            string automationFilePath = null;

            automationFileName = Path.ChangeExtension(StepID.Get(context),AutomationExtension.Get(context));

            if (Path.IsPathRooted(automationFileName))
                automationFilePath = automationFileName;
            else
                automationFilePath = Path.Combine(Directory.GetCurrentDirectory(), automationFileName);

            if (File.Exists(automationFilePath))
                AutomationFileExists.Set(context, true);
            else
                AutomationFileExists.Set(context, false);
        }
    }
}
