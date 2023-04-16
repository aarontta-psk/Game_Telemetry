using System.Runtime.Serialization.Json;
using System.Reflection;
using System.Text;

namespace game_telemetry
{
    public class CsvSerializer : ISerializer
    {
        public string Serialize(TelemetryEvent t_event)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (PropertyInfo propertyInfo in t_event.GetType().GetProperties())
                stringBuilder.AppendFormat("{0},", propertyInfo.GetValue(t_event, null));
            return stringBuilder.ToString();
        }

        public string Extension()
        {
            return ".csv";
        }
    }
}