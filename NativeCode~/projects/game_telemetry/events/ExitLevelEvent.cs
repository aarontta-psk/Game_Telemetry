namespace game_telemetry
{
    public class ExitLevelEvent : TelemetryEvent
    {
        public int Level { get; set; }

        public ExitLevelEvent(EventType type, int lvl) : base(type)
        {
            Level = lvl;
        }
    }
}