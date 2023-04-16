using System.IO;

namespace game_telemetry
{
    class FilePersistence : Persistence
    {
        const string TelemetryDirectory = "../../telemetry_data/";
        string fileName;

        public FilePersistence(ISerializer serializer_) : base(serializer_)
        {
            if (!Directory.Exists(TelemetryDirectory))
                Directory.CreateDirectory(TelemetryDirectory);
            fileName = TelemetryDirectory + Telemetry.Instance.SessionID.ToString() + serializer.Extension();
        }

        public override void Save(TelemetryEvent t_event)
        {
            using (StreamWriter streamWriter = new StreamWriter(fileName, true))
            {
                string serialisedEvent = serializer.Serialize(t_event);
                streamWriter.WriteLine(serialisedEvent);
            }
        }
    }
}
