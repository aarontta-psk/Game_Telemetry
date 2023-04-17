
namespace game_telemetry
{
    public class EndLevelEvent:TelemetryEvent
    {
        public int CurrentLevel { get; private set; }

        public EndLevelEvent(EventType type, int currentLevel) : base(type)
        {
            CurrentLevel = currentLevel;
        }
    }
}
