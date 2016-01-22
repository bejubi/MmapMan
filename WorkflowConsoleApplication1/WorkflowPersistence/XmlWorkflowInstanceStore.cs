namespace WorkflowConsoleApplication1.WorkflowPersistence
{
    using System;
    using System.Activities.DurableInstancing;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.DurableInstancing;
    using System.Runtime.Serialization;
    using System.ServiceModel.Persistence;
    using System.Xml;
    using System.Xml.Linq;

    /// <summary>
    /// 
    /// </summary>
    /// <example>Refer to https://msdn.microsoft.com/en-us/library/ee473462(v=vs.110).aspx </example>
    public class XmlWorkflowInstanceStore : InstanceStore
    {
        readonly Guid ownerInstanceId;

        public XmlWorkflowInstanceStore() : this(Guid.NewGuid()) { }

        public XmlWorkflowInstanceStore(Guid id)
        {
            this.ownerInstanceId = id;
        }

        //Synchronous version of the Begin/EndTryCommand functions
        protected override bool TryCommand(InstancePersistenceContext context, InstancePersistenceCommand command, TimeSpan timeout)
        {
            return this.EndTryCommand(this.BeginTryCommand(context, command, timeout, null, null));
        }

        //The persistence engine will send a variety of commands to the configured InstanceStore,
        //such as CreateWorkflowOwnerCommand, SaveWorkflowCommand, and LoadWorkflowCommand.
        //This method is where we will handle those commands
        protected override IAsyncResult BeginTryCommand(InstancePersistenceContext context, InstancePersistenceCommand command, TimeSpan timeout, AsyncCallback callback, object state)
        {
            IDictionary<XName, InstanceValue> data;

            //The CreateWorkflowOwner command instructs the instance store to create a new instance owner bound to the instanace handle
            if (command is CreateWorkflowOwnerCommand)
            {
                context.BindInstanceOwner(this.ownerInstanceId, Guid.NewGuid());
            }
            //The SaveWorkflow command instructs the instance store to modify the instance bound to the instance handle or an instance key
            else if (command is SaveWorkflowCommand)
            {
                var saveCommand = (SaveWorkflowCommand)command;
                data = saveCommand.InstanceData;

                this.Save(data);
            }
            //The LoadWorkflow command instructs the instance store to lock and load the instance bound to the identifier in the instance handle
            else if (command is LoadWorkflowCommand)
            {
                var fileName = IoHelper.GetFileName(this.ownerInstanceId);

                using (var inputStream = new FileStream(fileName, FileMode.Open))
                {
                    data = LoadInstanceDataFromFile(inputStream);
                    //load the data into the persistence Context
                    context.LoadedInstance(InstanceState.Initialized, data, null, null, null);
                }
            }

            return new CompletedAsyncResult<bool>(true, callback, state);
        }

        protected override bool EndTryCommand(IAsyncResult result)
        {
            return CompletedAsyncResult<bool>.End(result);
        }

        //Reads data from xml file and creates a dictionary based off of that.
        static IDictionary<XName, InstanceValue> LoadInstanceDataFromFile(Stream inputStream)
        {
            IDictionary<XName, InstanceValue> data = new Dictionary<XName, InstanceValue>();

            var serializer = new NetDataContractSerializer();

            using (var xmlReader = XmlReader.Create(inputStream))
            {
                var doc = new XmlDocument();
                doc.Load(xmlReader);

                var instances = doc.GetElementsByTagName("InstanceValue");
                foreach (XmlElement instanceElement in instances)
                {
                    var keyElement = (XmlElement)instanceElement.SelectSingleNode("descendant::key");
                    var key = (XName)DeserializeObject(serializer, keyElement);

                    var valueElement = (XmlElement)instanceElement.SelectSingleNode("descendant::value");
                    var value = DeserializeObject(serializer, valueElement);
                    var instVal = new InstanceValue(value);

                    data.Add(key, instVal);
                }
            }

            return data;
        }

        static object DeserializeObject(IFormatter serializer, XmlNode element)
        {
            using (var memoryStream = new MemoryStream())
            using (var xmlDictionaryWriter = XmlDictionaryWriter.CreateTextWriter(memoryStream))
            {
                element.WriteContentTo(xmlDictionaryWriter);
                xmlDictionaryWriter.Flush();
                memoryStream.Position = 0;

                var deserializedObject = serializer.Deserialize(memoryStream);
                return deserializedObject;
            }
        }

        //Saves the persistence data to an xml file.
        void Save(IEnumerable<KeyValuePair<XName, InstanceValue>> instanceData)
        {
            var fileName = IoHelper.GetFileName(this.ownerInstanceId);
            var doc = new XmlDocument();
            doc.LoadXml("<InstanceValues/>");

            foreach (var valPair in instanceData)
            {
                var newInstance = doc.CreateElement("InstanceValue");

                var newKey = this.SerializeObject("key", valPair.Key, doc);
                newInstance.AppendChild(newKey);

                var newValue = this.SerializeObject("value", valPair.Value.Value, doc);
                newInstance.AppendChild(newValue);

                doc.DocumentElement.AppendChild(newInstance);
            }

            doc.Save(fileName);
        }

        public XmlElement SerializeObject(string elementName, object o, XmlDocument doc)
        {
            var serializer = new NetDataContractSerializer();
            var newElement = doc.CreateElement(elementName);

            using (var memoryStream = new MemoryStream())
            {
                serializer.Serialize(memoryStream, o);
                memoryStream.Position = 0;
                var rdr = new StreamReader(memoryStream);
                newElement.InnerXml = rdr.ReadToEnd();
            }

            return newElement;
        }
    }
}
