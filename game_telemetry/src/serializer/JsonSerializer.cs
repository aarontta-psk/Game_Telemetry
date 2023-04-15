namespace game_telemetry
{
    public class JsonSerializer : ISerializer
    {
        public string Serialize(TelemetryEvent t_event)
        {
            return System.Text.Json.JsonSerializer.Serialize(t_event);
        }
    }
}