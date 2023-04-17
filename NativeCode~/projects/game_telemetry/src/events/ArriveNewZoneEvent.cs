
namespace game_telemetry
{
    public class ArriveNewZoneEvent: TelemetryEvent
    {
        //ID DE SECCION
        public int ZoneID { get; private set; }

        public ArriveNewZoneEvent(EventType type, int zoneID) : base(type)
        {
            ZoneID = zoneID;
        }
    }
}
