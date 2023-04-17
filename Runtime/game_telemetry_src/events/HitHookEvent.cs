using Newtonsoft.Json;

namespace game_telemetry
{
    [System.Serializable]
    public class HitHookEvent : TelemetryEvent
    {
        [JsonProperty(Order = 4)]
        public int PosHookX { get; private set; }
        [JsonProperty(Order = 5)]
        public int PosHookY { get; private set; }
        [JsonProperty(Order = 6)]
        public int AccelerationX { get; private set; }
        [JsonProperty(Order = 7)]
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
