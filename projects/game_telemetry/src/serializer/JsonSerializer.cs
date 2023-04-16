﻿//using System.Runtime.Serialization.Json;
using Newtonsoft.Json;

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

            //return System.Text.Json.JsonSerializer.Serialize(t_event);

            JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings();
            jsonSerializerSettings.Formatting = Formatting.Indented;
            return JsonConvert.SerializeObject(t_event, jsonSerializerSettings);

            //return "sike";
        }

        public string Extension()
        {
            return ".json";
        }
    }
}