using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_telemetry
{
    class ThrowHookEvent: TelemetryEvent
    {
        int posPlayerX;
        int posPlayerY;
        int posMouseX;
        int posMouseY;
        int numHooks;
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
