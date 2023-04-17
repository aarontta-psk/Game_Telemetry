﻿
namespace game_telemetry
{
    [System.Serializable]
    public class StartLevelEvent:TelemetryEvent
    {
        public int CurrentLevel { get; private set; }
        public StartLevelEvent(EventType type,int currentLevel) : base(type)
        {
            CurrentLevel = currentLevel;
        }
    }
}
