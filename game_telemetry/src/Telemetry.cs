using System.Collections.Concurrent;

namespace game_telemetry
{
    public class Telemetry
    {
        private static Telemetry instance = null;

        private const int ThreadDelay = 5000; // in ms
        Thread telemetryThread;

        private Persistence[] persistences;
        private ConcurrentQueue<TelemetryEvent> eventQueue;

        private long sessionID;
        public long SessionID { get { return sessionID; } set { sessionID = value; } }

        private string gameName;
        public string GameName { get { return gameName; } set { gameName = value; } }

        private Telemetry() { }

        public static Telemetry Instance
        {
            get
            {
                if (instance == null) {
                    instance = new Telemetry();
                    instance.TelemetrySetup();
                }

                return instance;
            }
        }

        private void Run()
        {
            while (true)
            {
                TelemetryEvent? t_event;
                while (eventQueue.TryDequeue(out t_event)) {
                    foreach (Persistence persistence in persistences)
                        persistence.Save(t_event);
                }

                Thread.Sleep(ThreadDelay);
            }
        }

        public void TrackEvent(TelemetryEvent t_event)
        {
            eventQueue.Enqueue(t_event);
        }

        private void TelemetrySetup()
        {
            Telemetry.Instance.SessionID = 1232341231234;
            
            eventQueue = new ConcurrentQueue<TelemetryEvent>();

            persistences = new Persistence[1];
            persistences[0] = new FilePersistence(new JsonSerializer());

            telemetryThread = new Thread(Run);
            telemetryThread.Start();
        }
    }
}