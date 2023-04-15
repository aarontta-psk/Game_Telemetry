namespace game_telemetry
{
    [System.Serializable]
    public class TelemetryEvent
    {
        public enum EventType { DEFAULT, NOT_DEFAULT };

        public EventType eventType;
        public string sessionID;
        public long timestamp;

        protected TelemetryEvent(EventType type, string session_id)
        {
            eventType = type;
            sessionID = Telemetry.Instance.SessionID.ToString();

            timestamp = ((DateTimeOffset)DateTime.UtcNow).ToUnixTimeSeconds();
        }
    }
}