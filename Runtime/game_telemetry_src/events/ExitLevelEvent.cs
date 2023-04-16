namespace game_telemetry
{
    public class ExitLevelEvent : TelemetryEvent
    {
        public int level;

        public ExitLevelEvent(EventType type, int lvl) : base(type)
        {
            level = lvl;
        }
    }
}