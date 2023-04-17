namespace game_telemetry
{
    public class ReceiveDamageEvent : TelemetryEvent
    {
        public enum DamageType { ENEMY, OBSTACLE }
        public DamageType DmgType { get; private set; }
        public int PosPlayerX { get; private set; }
        public int PosPlayerY { get; private set; }

        public ReceiveDamageEvent(EventType type, int posPlayerX, int posPlayerY,DamageType dmgType) : base(type)
        {
            PosPlayerX = posPlayerX;
            PosPlayerY = posPlayerY;
            DmgType = dmgType;
        }
    }
}