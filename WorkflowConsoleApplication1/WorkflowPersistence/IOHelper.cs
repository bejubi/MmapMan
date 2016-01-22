namespace WorkflowConsoleApplication1.WorkflowPersistence
{
    using System;
    using System.Globalization;
    using System.IO;

    public static class IoHelper
    {
        public static readonly string InstanceFormatString = "{0}.xml";
        public static readonly string PersistenceDirectory = "FilePersistenceProvider";
        public static readonly string PersistenceArchiveDirectory = Path.Combine(PersistenceDirectory, "Archive");

        public static string GetFileName(Guid id)
        {
            EnsurePersistenceFolderExists();
            return Path.Combine(PersistenceDirectory, string.Format(CultureInfo.InvariantCulture, InstanceFormatString, id));
        }

        public static void EnsurePersistenceFolderExists()
        {
            if (!Directory.Exists(PersistenceDirectory))
            {
                Directory.CreateDirectory(PersistenceDirectory);
            }
        }

        public static void EnsurePersistenceArchiveFolderExists()
        {
            if (!Directory.Exists(PersistenceArchiveDirectory))
            {
                Directory.CreateDirectory(PersistenceArchiveDirectory);
            }
        }

        public static void ArchivePersistenceFolder()
        {
            EnsurePersistenceArchiveFolderExists();
            var files = Directory.GetFiles(PersistenceDirectory);
            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                var destinationFilePath = Path.Combine(
                    PersistenceArchiveDirectory,
                    string.Format(CultureInfo.InvariantCulture, InstanceFormatString, fileInfo.Name));

                fileInfo.MoveTo(destinationFilePath);
            }
        }
    }
}
