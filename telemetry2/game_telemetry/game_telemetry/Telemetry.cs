

using System.Collections.Concurrent;

namespace game_telemetry
{
    public class Telemetry
    {
        private static Telemetry instance = null;

        private Persistence[] persistences;
        private ConcurrentQueue<TelemetryEvent> eventQueue;

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

        private void Run()
        {
            while (true)
            {
                // cosas

                Thread.Sleep(5000);
            }
        }

        public void TrackEvent(TelemetryEvent t_event)
        {
            //foreach(Persistence p in persistences)
            //    p.Save(t_event);

        }
    }
}