namespace MmapManager.Console.Activity
{
    using System.Activities;
    using System.IO;

    public class FileExists : CodeActivity
    {
        public InArgument<string> StepId { get; set; }
        public InArgument<string> AutomationExtension { get; set; }

        public OutArgument<bool> AutomationFileExists { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            var automationFileName = Path.ChangeExtension(this.StepId.Get(context), this.AutomationExtension.Get(context));
            var automationFilePath = Path.IsPathRooted(automationFileName) ? automationFileName : Path.Combine(Directory.GetCurrentDirectory(), automationFileName);

            this.AutomationFileExists.Set(context, File.Exists(automationFilePath));
        }
    }
}
