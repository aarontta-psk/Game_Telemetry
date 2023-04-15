namespace game_telemetry
{
    public class LandingEvent : TelemetryEvent
    {
        public int posPlayerX;
        public int posPlayerY;

        public LandingEvent(EventType type, int posPlayerXAux, int posPlayerYAux) : base(type)
        {
            posPlayerX = posPlayerXAux;
            posPlayerY = posPlayerYAux;
        }
    }
}
