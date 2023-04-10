namespace game_telemetry
{
    public interface ISerializer
    {
        public string Serialize(TelemetryEvent e);
    }
}