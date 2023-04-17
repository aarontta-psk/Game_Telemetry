using Newtonsoft.Json;

namespace game_telemetry
{
    [System.Serializable]
    public class LandingEvent : TelemetryEvent
    {
        [JsonProperty(Order = 4)]
        public int PosPlayerX { get; private set; }
        [JsonProperty(Order = 5)]
        public int PosPlayerY { get; private set; }

        public LandingEvent(EventType type, int posPlayerX, int posPlayerY) : base(type)
        {
            PosPlayerX = posPlayerX;
            PosPlayerY = posPlayerY;
        }
    }
}
