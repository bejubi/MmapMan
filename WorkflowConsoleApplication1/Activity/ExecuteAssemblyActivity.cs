using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using System.Reflection; 

namespace WorkflowConsoleApplication1.Activity
{

    public sealed class ExecuteAssemblyActivity : CodeActivity
    {
        // Define an activity input argument of type string
        public InArgument<string> Text { get; set; }

        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override void Execute(CodeActivityContext context)
        {
            // Obtain the runtime value of the Text input argument
            string text = context.GetValue(this.Text);

            Assembly SampleAssembly = Assembly.LoadFrom("..\\..\\lib\\WorkFlowAssembly.dll");
            Type myType = SampleAssembly.GetTypes()[0];
            MethodInfo Method = myType.GetMethod("SendSlackMessage");
            object myInstance = Activator.CreateInstance(myType);
            Method.Invoke(myInstance, new object[] { "Sending a parameter message" });
        }
    }
}
