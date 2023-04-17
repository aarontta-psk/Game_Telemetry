namespace game_telemetry
{
    public class HitHookEvent : TelemetryEvent
    {
        public int PosHookX { get; private set; }
        public int PosHookY { get; private set; }
        public int AccelerationX { get; private set; }
        public int AccelerationY { get; private set; }

        public HitHookEvent(EventType type, int posHookX, int posHookY, int accelerationX, int accelerationY) : base(type)
        {
            PosHookX = posHookX;
            PosHookY = posHookY;
            AccelerationX = accelerationX;
            AccelerationY = accelerationY;
        }
    }
}
