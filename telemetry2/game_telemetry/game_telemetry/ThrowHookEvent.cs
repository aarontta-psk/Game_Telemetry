using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_telemetry
{
    class ThrowHookEvent: TelemetryEvent
    {
        public int posPlayerX;
        public int posPlayerY;
        public int posMouseX;
        public int posMouseY;
        public int numHooks;
        protected ThrowHookEvent(EventType type, string session_id, int posPlayerXAux,int posPlayerYAux,int posMouseXAux,int posMouseYAux,int numHooksAux) : base(type, session_id)
        {
            posPlayerX = posPlayerXAux;
            posPlayerY = posPlayerYAux;
            posMouseX = posMouseXAux;
            posMouseY = posMouseYAux;
            numHooks = numHooksAux;
        }
    }
}
