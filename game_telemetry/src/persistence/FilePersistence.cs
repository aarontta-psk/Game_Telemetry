namespace game_telemetry
{
    class FilePersistence : Persistence
    {

        const string Directory = "./temp/Folder/";
        FileStream fileStream;

        public FilePersistence(ISerializer serializer_) : base(serializer_)
        {
            string file = Directory + Telemetry.Instance.SessionID.ToString();

            fileStream = File.Open(file, FileMode.Create);
        }

        public override void Save(TelemetryEvent t_event)
        {
            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.WriteLine("aqui va lo que tiene que guardar");
            streamWriter.Close();
        }
    }
}
