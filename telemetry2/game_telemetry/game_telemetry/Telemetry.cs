

namespace game_telemetry
{
    public class Telemetry
    {
        private static Telemetry instance = null;

        private Persistence[] persistences;

        private Telemetry()
        {

        }

        public static Telemetry Instance
        {
            get
            {
                if (instance == null)
                    instance = new Telemetry();

                return instance;
            }
        }

        public void TrackEvent(TelemetryEvent t_event)
        {
            foreach(Persistence p in persistences)
                p.Save(t_event);
        }
    }
}