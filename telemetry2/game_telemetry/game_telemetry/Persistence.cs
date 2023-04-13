

using System.Collections.Concurrent;

namespace game_telemetry
{
    public abstract class Persistence
    {
        public Persistence()
        {

        }

        public abstract void Save(TelemetryEvent ev);
    }
}
