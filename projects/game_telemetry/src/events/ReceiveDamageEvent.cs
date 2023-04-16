namespace game_telemetry
{
    public class ReceiveDamageEvent : TelemetryEvent
    {
        public int posPlayerX;
        public int posPlayerY;

        public ReceiveDamageEvent(EventType type, int posPlayerXAux, int posPlayerYAux, int posMouseXAux, int posMouseYAux, int numHooksAux) : base(type)
        {
            posPlayerX = posPlayerXAux;
            posPlayerY = posPlayerYAux;
        }
    }
}