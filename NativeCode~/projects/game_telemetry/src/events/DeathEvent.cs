namespace game_telemetry
{
    public class DeathEvent :TelemetryEvent
    {
        public enum DeathType { FELL, DAMAGE};

        public DeathType Death { get; private set; }
        public int PosPlayerX { get; private set; }
        public int PosPlayerY { get; private set; }
        public int ZoneID { get; private set; }

        public DeathEvent(EventType type, int posPlayerX, int posPlayerY, DeathType death, int zoneID) : base(type)
        {
            Death = death;
            PosPlayerX = posPlayerX;
            PosPlayerY = posPlayerY;
            ZoneID = zoneID;
        }
    }
}
