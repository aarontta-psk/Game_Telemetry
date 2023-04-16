namespace game_telemetry
{
    [System.Serializable]
    public class TelemetryEvent
    {
        public enum EventType { DEFAULT, NOT_DEFAULT };

        public string Type { get; set; }
        public long SessionID { get; set; }
        public long TimeStamp { get; set; }

        protected TelemetryEvent(EventType type)
        {
            Type = type.ToString();
            SessionID = Telemetry.Instance.SessionID;

            TimeStamp = ((System.DateTimeOffset)System.DateTime.UtcNow).ToUnixTimeSeconds();
        }
    }
}