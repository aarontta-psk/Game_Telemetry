

using System.Collections.Concurrent;

namespace game_telemetry
{
    public abstract class Persistence
    {
        public enum SerializeType { JSON, BINARY }

        public Persistence()
        {

        }

        public abstract void Save(TelemetryEvent ev);

        private ConcurrentQueue<TelemetryEvent> eventQueue;
    }
}
