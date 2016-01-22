namespace WorkflowConsoleApplication1
{
    using System;
    using System.Activities;

    using WorkflowConsoleApplication1.WorkflowPersistence;

    public class Workflow1Handler
    {
        public static void Start(Guid? instanceId)
        {
            var instance = new WorkflowApplication(new Workflow1());
            instance.PersistableIdle += OnPersistableIdle;
            instance.Completed += OnCompleted;
            instance.Idle += OnIdle;
            instance.Unloaded += OnUnloaded;

            // UNDONE: (maj) rather than using parameters, first check to see if there is an incomplete persisted file
            // and start from there
            if (!instanceId.HasValue)
            {
                instance.InstanceStore = new XmlWorkflowInstanceStore(instance.Id);
                instance.Run();
            }
            else
            {
                instance.InstanceStore = new XmlWorkflowInstanceStore(instanceId.Value);
                instance.Load(instanceId.Value);
                instance.Run();
            }
        }

        private static void OnUnloaded(WorkflowApplicationEventArgs workflowApplicationEventArgs)
        {
            // UNDONE: (maj) consider moving this to the workflow, itself, not this event, in a custom activity
            IoHelper.ArchivePersistenceFolder();
        }

        private static void OnIdle(WorkflowApplicationIdleEventArgs workflowApplicationIdleEventArgs)
        {

        }

        private static void OnCompleted(WorkflowApplicationCompletedEventArgs workflowApplicationCompletedEventArgs)
        {

        }

        private static PersistableIdleAction OnPersistableIdle(WorkflowApplicationIdleEventArgs workflowApplicationIdleEventArgs)
        {
            return PersistableIdleAction.Persist;
        }
    }
}
