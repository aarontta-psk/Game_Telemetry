
namespace game_telemetry
{
    public class EndLevelEvent:TelemetryEvent
    {
        int currentLevel;
        public EndLevelEvent(EventType type, int currentLevelAux) : base(type)
        {
            currentLevel = currentLevelAux;
        }
    }
}
