using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_telemetry
{
    class HitHookEvent : TelemetryEvent
    {
        public int posHookX;
        public int posHookY;
        public int accelerationX;
        public int accelerationY;
        protected HitHookEvent(EventType type, string session_id, int posHookXAux, int posHookYAux, int accelerationXAux, int accelerationYAux) : base(type, session_id)
        {
            posHookX = posHookXAux;
            posHookY = posHookYAux;
            accelerationX = accelerationXAux;
            accelerationY = accelerationYAux;
        }
    }
}
