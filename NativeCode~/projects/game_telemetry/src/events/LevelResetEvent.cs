using Newtonsoft.Json;

namespace game_telemetry
{
    [System.Serializable]
    public class LevelResetEvent : TelemetryEvent
    {
        //Posicion ANTES del reinicio
        [JsonProperty(Order = 4)]
        public int PosPlayerX { get; private set; }
        [JsonProperty(Order = 5)]
        public int PosPlayerY { get; private set; }
        [JsonProperty(Order = 6)]
        public int CurrentLevel { get; private set; }

        public LevelResetEvent(EventType type, int posPlayerX, int posPlayerY, int currentLevel) : base(type)
        {
            PosPlayerX = posPlayerX;
            PosPlayerY = posPlayerY;
            CurrentLevel = currentLevel;
        }
    }
}