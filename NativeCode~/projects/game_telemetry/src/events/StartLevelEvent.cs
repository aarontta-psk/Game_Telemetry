
namespace game_telemetry
{
    public class StartLevelEvent:TelemetryEvent
    {
        int currentLevel;
        public StartLevelEvent(EventType type,int currentLevelAux) : base(type)
        {
            currentLevel = currentLevelAux;
        }
    }
}
