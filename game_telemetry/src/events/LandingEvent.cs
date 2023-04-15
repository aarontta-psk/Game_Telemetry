using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_telemetry
{
    class LandingEvent : TelemetryEvent
    {
        public int posPlayerX;
        public int posPlayerY;

        protected LandingEvent(EventType type, string session_id, int posPlayerXAux, int posPlayerYAux) : base(type, session_id)
        {
            posPlayerX = posPlayerXAux;
            posPlayerY = posPlayerYAux;
        }
    }
}
