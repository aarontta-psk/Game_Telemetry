using System;
using System.Collections.Concurrent;
using System.Threading;

namespace game_telemetry
{
    public class Telemetry
    {
        private static Telemetry? instance;

        private const int ThreadDelay = 5000; // in ms
        private Thread telemetryThread;
        private bool runningThread;

        private Persistence[] persistences;
        private ConcurrentQueue<TelemetryEvent> eventQueue;

        private long sessionID;
        public long SessionID { get => sessionID; private set { sessionID = value; } }

        private string gameName;
        public string GameName { get => gameName; private set { gameName = value; } }

        private Telemetry() { }

        public static Telemetry Instance => instance;

        public static bool Init(string gameName_, long sessionId_)
        {
            if (instance == null)
            {
                instance = new Telemetry();
                instance.TelemetrySetup(gameName_, sessionId_);
                return true;
            }
            Console.WriteLine("Ya has inicializado la instancia.");
            return false;
        }

        public static void Release()
        {
            instance.TelemetryStop();
            instance = null;
        }

        public void TrackEvent(TelemetryEvent t_event)
        {
            eventQueue.Enqueue(t_event);
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

        private void TelemetrySetup(string gameName_, long sessionId_)
        {
            GameName = gameName_;
            SessionID = sessionId_;
            
            eventQueue = new ConcurrentQueue<TelemetryEvent>();

            persistences = new Persistence[3];
            persistences[0] = new FilePersistence(new JsonSerializer());
            persistences[1] = new FilePersistence(new CsvSerializer());
            persistences[2] = new FilePersistence(new BinarySerializer());

            runningThread = true;
            telemetryThread = new Thread(Run);
            telemetryThread.Start();
        }

        private void TelemetryStop()
        {
            runningThread = false;
            eventQueue.Enqueue(new SessionEndEvent(TelemetryEvent.EventType.SESSION_END));
            telemetryThread.Join();
        }
    }
}