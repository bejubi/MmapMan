using System;

namespace MmapManager.Console.Activity
{
    using System.Activities;
    using System.IO;
    using System.Management.Automation;
    using System.Management.Automation.Runspaces;

    public class ExecutePowershellScript : CodeActivity
    {
        public InArgument<string> ScriptPath { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            var scriptPath = ScriptPath.Get(context);
            string scriptContents;

            if (!(Path.IsPathRooted(scriptPath)))
                scriptPath = Path.Combine(Directory.GetCurrentDirectory(), scriptPath);

            if (File.Exists(scriptPath))
                scriptContents = File.ReadAllText(scriptPath);
            else
                throw new FileNotFoundException(String.Format("Powershell script file {0} does not exist.", scriptPath));

            var runSpace = RunspaceFactory.CreateRunspace();
            runSpace.Open();

            var runSpaceInvoker = new RunspaceInvoke(runSpace);

            var pipeLine = runSpace.CreatePipeline();
            pipeLine.Commands.AddScript(scriptContents);
            pipeLine.Commands.Add("Out-String");

            var returnObjects = pipeLine.Invoke();
            runSpace.Close();
        }
    }
}
