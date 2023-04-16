namespace game_telemetry
{
    public class ThrowHookEvent : TelemetryEvent
    {
        public int posPlayerX;
        public int posPlayerY;
        public int posMouseX;
        public int posMouseY;
        public int numHooks;

        protected ThrowHookEvent(EventType type, int posPlayerXAux,int posPlayerYAux,int posMouseXAux,int posMouseYAux,int numHooksAux) : base(type)
        {
            posPlayerX = posPlayerXAux;
            posPlayerY = posPlayerYAux;
            posMouseX = posMouseXAux;
            posMouseY = posMouseYAux;
            numHooks = numHooksAux;
        }
    }
}
