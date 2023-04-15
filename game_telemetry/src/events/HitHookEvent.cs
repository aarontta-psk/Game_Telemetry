namespace game_telemetry
{
    public class HitHookEvent : TelemetryEvent
    {
        public int posHookX;
        public int posHookY;
        public int accelerationX;
        public int accelerationY;
        public HitHookEvent(EventType type, int posHookXAux, int posHookYAux, int accelerationXAux, int accelerationYAux) : base(type)
        {
            posHookX = posHookXAux;
            posHookY = posHookYAux;
            accelerationX = accelerationXAux;
            accelerationY = accelerationYAux;
        }
    }
}
