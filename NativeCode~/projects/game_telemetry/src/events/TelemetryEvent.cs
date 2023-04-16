namespace game_telemetry
{
    [System.Serializable]
    public class TelemetryEvent
    {
        public enum EventType { DEFAULT, NOT_DEFAULT };

        public string type;
        public long sessionID;
        public long timeStamp;

        protected TelemetryEvent(EventType type)
        {
            this.type = type.ToString();
            sessionID = Telemetry.Instance.SessionID;

            timeStamp = ((System.DateTimeOffset)System.DateTime.UtcNow).ToUnixTimeSeconds();
        }
    }
}