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

        private int sessionID;
        public int SessionID { get { return sessionID; } set { sessionID = value; } }

        private Telemetry()
        {
            eventQueue = new ConcurrentQueue<TelemetryEvent>();

            persistences = new Persistence[1];
            persistences[0] = new FilePersistence(new JsonSerializer());

            telemetryThread = new Thread(Run);
            telemetryThread.Start();
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
                Console.WriteLine("bobo");
                Thread.Sleep(ThreadDelay);
            }
        }

        public void TrackEvent(TelemetryEvent t_event)
        {
            eventQueue.Enqueue(t_event);
        }

        static void Main(string[] args)
        {
            Telemetry.Instance.TrackEvent(new ExitLevelEvent(TelemetryEvent.EventType.DEFAULT, "9", 2));

            Thread.Sleep(10000);
        }
    }
}