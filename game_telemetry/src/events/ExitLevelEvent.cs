using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_telemetry
{
    class ExitLevelEvent : TelemetryEvent
    {
        public int level;
        public ExitLevelEvent(EventType type, string session_id, int levelAux) : base(type, session_id)
        {
            level = levelAux;
        }
    }
}