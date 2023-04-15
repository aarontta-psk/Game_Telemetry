using System.Runtime.Serialization.Json;

namespace game_telemetry
{
    public class JsonSerializer : ISerializer
    {
        public string Serialize(TelemetryEvent t_event)
        {
            //using (MemoryStream memoryStream = new MemoryStream())
            //{
            //    DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(TelemetryEvent));
            //    ser.WriteObject(memoryStream, t_event);
            //    return System.Text.Encoding.Default.GetString(memoryStream.ToArray());
            //}
            return System.Text.Json.JsonSerializer.Serialize(t_event);
        }

        public string Extension()
        {
            return ".json";
        }
    }
}