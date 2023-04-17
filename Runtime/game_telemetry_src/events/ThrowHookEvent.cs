using Newtonsoft.Json;

namespace game_telemetry
{
    [System.Serializable]
    public class ThrowHookEvent : TelemetryEvent
    {
        [JsonProperty(Order = 4)]
        public int PosPlayerX { get; private set; }
        [JsonProperty(Order = 5)]
        public int PosPlayerY { get; private set; }
        [JsonProperty(Order = 6)]
        public int PosMouseX { get; private set; }
        [JsonProperty(Order = 7)]
        public int PosMouseY { get; private set; }
        [JsonProperty(Order = 8)]
        public int NumHooks { get; private set; }

        protected ThrowHookEvent(EventType type, int posPlayerX, int posPlayerY, int posMouseX, int posMouseY, int numHooks) : base(type)
        {
            PosPlayerX = posPlayerX;
            PosPlayerY = posPlayerY;
            PosMouseX = posMouseX;
            PosMouseY = posMouseY;
            NumHooks = numHooks;
        }
    }
}
