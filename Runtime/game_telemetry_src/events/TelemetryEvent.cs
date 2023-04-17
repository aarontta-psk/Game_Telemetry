namespace game_telemetry
{
    [System.Serializable]
    public class TelemetryEvent
    {
        public enum EventType { DEFAULT, ARRIVE_NEW_ZONE, DEATH, END_LEVEL, EXIT_LEVEL, HIT_HOOK, LANDING_EVENT, 
                                LEVEL_RESET, RECEIVE_DMG, SESSION_END, SESSION_START, START_LEVEL, THROW_HOOK};

        public string Type { get; private set; }
        public long SessionID { get; private set; }
        public long TimeStamp { get; private set; }

        protected TelemetryEvent(EventType type)
        {
            Type = type.ToString();
            SessionID = Telemetry.Instance.SessionID;

            TimeStamp = ((System.DateTimeOffset)System.DateTime.UtcNow).ToUnixTimeSeconds();
        }
    }
}