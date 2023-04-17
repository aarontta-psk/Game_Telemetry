namespace game_telemetry
{
    public class ThrowHookEvent : TelemetryEvent
    {
        public int PosPlayerX { get; private set; }
        public int PosPlayerY { get; private set; }
        public int PosMouseX { get; private set; }
        public int PosMouseY { get; private set; }
        public int NumHooks { get; private set; }

        protected ThrowHookEvent(EventType type, int posPlayerX,int posPlayerY,int posMouseX,int posMouseY,int numHooks) : base(type)
        {
            PosPlayerX = posPlayerX;
            PosPlayerY = posPlayerY;
            PosMouseX = posMouseX;
            PosMouseY = posMouseY;
            NumHooks = numHooks;
        }
    }
}
