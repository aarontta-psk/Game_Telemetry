

using System.Collections.Concurrent;

namespace game_telemetry
{
    public abstract class Persistence
    {
        protected ISerializer serializer;

        public Persistence(ISerializer serializer_)
        {
            serializer = serializer_;
        }

        public abstract void Save(TelemetryEvent telemetryEvent);
    }
}
