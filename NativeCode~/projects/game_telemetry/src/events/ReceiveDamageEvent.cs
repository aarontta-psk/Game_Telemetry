namespace game_telemetry
{
    public class ReceiveDamageEvent : TelemetryEvent
    {
        public int posPlayerX;
        public int posPlayerY;
        public enum DamageType { ENEMY, OBSTACLE }
        public DamageType dmgType;

        public ReceiveDamageEvent(EventType type, int posPlayerXAux, int posPlayerYAux,DamageType dmgTypeAux) : base(type)
        {
            posPlayerX = posPlayerXAux;
            posPlayerY = posPlayerYAux;
            dmgType = dmgTypeAux;
        }
    }
}