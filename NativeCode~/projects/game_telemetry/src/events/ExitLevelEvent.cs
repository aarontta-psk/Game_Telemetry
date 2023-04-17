namespace game_telemetry
{
    public class ExitLevelEvent : TelemetryEvent
    {
        public int Level { get; private set; }

        public ExitLevelEvent(EventType type, int level) : base(type)
        {
            Level = level;
        }
    }
}