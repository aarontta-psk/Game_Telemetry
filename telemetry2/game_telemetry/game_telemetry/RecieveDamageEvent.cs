using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_telemetry
{
    class RecieveDamageEvent
    {
        int posPlayerX;
        int posPlayerY;

        protected RecieveDamageEvent(EventType type, string session_id, int posPlayerXAux, int posPlayerYAux, int posMouseXAux, int posMouseYAux, int numHooksAux) : base(type, session_id)
        {
            posPlayerX = posPlayerXAux;
            posPlayerY = posPlayerYAux;
        }
    }
}