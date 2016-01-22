using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using System.Reflection; 

namespace MmapManager.Console.Activity
{

    public sealed class ExecuteAssembly : CodeActivity
    {
        // Define an activity input argument of type string
        public InArgument<string> AssemblyName { get; set; }

        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override void Execute(CodeActivityContext context)
        {
            // Obtain the runtime value of the Text input argument
            string assemblyName = context.GetValue(this.AssemblyName);


            Assembly SampleAssembly = Assembly.LoadFrom(assemblyName);
            Type myType = SampleAssembly.GetTypes()[0];
            MethodInfo Method = myType.GetMethod("DoIt");
            object myInstance = Activator.CreateInstance(myType);
            Method.Invoke(myInstance, null);
        }
    }
}

