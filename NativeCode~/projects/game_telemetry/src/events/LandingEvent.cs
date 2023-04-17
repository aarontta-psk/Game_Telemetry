namespace game_telemetry
{
    public class LandingEvent : TelemetryEvent
    {
        public int PosPlayerX { get; private set; }
        public int PosPlayerY { get; private set; }

        public LandingEvent(EventType type, int posPlayerX, int posPlayerY) : base(type)
        {
            PosPlayerX = posPlayerX;
            PosPlayerY = posPlayerY;
        }
    }
}
