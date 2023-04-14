using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_telemetry
{
    class FilePersistence : Persistence
    {

        const string Directory = "./temp/Folder/";
        FileStream fileStream;

        public FilePersistence(ISerializer serializer_) : base(serializer_)
        {
            string file = Directory + Telemetry.Instance.TelemetrySession().ToString();

            fileStream = File.Open(file, FileMode.Create);
        }

        public override void Save(TelemetryEvent telemetryEvent)
        {
            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.WriteLine("aqui va lo que tiene que guardar");
            streamWriter.Close();
        }
    }
}
