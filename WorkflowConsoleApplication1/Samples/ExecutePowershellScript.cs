using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Activities;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.IO;
using System.Collections.ObjectModel;


namespace WorkflowConsoleApplication1.Samples
{
    public class ExecutePowershellScript : CodeActivity
    {
        public InArgument<string> ScriptPath { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            string scriptPath = ScriptPath.Get(context);
            string scriptContents = null;

            if (!(Path.IsPathRooted(scriptPath)))
                scriptPath = Path.Combine(Directory.GetCurrentDirectory(), scriptPath);

            if (File.Exists(scriptPath))
                scriptContents = File.ReadAllText(scriptPath);
            else
                throw new FileNotFoundException(String.Format("Powershell script file {0} does not exist.", scriptPath));

            Runspace runSpace = RunspaceFactory.CreateRunspace();
            runSpace.Open();

            RunspaceInvoke runSpaceInvoker = new RunspaceInvoke(runSpace);

            Pipeline pipeLine = runSpace.CreatePipeline();
            pipeLine.Commands.AddScript(scriptContents);
            pipeLine.Commands.Add("Out-String");

            Collection<PSObject> returnObjects = pipeLine.Invoke();
            runSpace.Close();
        }
    }
}
