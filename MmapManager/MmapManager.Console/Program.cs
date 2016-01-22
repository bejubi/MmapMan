using System.Activities;

namespace MmapManager.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var process = new WorkflowApplication(new Process());
            process.Run();

            System.Console.ReadKey();
        }
    }
}
