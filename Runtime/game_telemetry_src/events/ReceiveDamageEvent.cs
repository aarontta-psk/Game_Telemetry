using Newtonsoft.Json;

namespace game_telemetry
{
    [System.Serializable]
    public class ReceiveDamageEvent : TelemetryEvent
    {
        public enum DamageType { ENEMY, OBSTACLE }
        [JsonProperty(Order = 4)]
        public DamageType DmgType { get; private set; }
        [JsonProperty(Order = 5)]
        public int PosPlayerX { get; private set; }
        [JsonProperty(Order = 6)]
        public int PosPlayerY { get; private set; }

        public ReceiveDamageEvent(EventType type, int posPlayerX, int posPlayerY, DamageType dmgType) : base(type)
        {
            PosPlayerX = posPlayerX;
            PosPlayerY = posPlayerY;
            DmgType = dmgType;
        }
    }
}