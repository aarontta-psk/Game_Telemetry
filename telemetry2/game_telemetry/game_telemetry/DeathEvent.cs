using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_telemetry
{
    class DeathEvent:TelemetryEvent
    {
        enum deathType { FELL, DMG};

        int posPlayerX;
        int posPlayerY;
        deathType death;
        //ID DE SECCION QUE NO SE COMO HACER ESTO

        protected DeathEvent(EventType type, string session_id, int posPlayerXAux, int posPlayerYAux, deathType deathAux) : base(type, session_id)
        {
            posPlayerX = posPlayerXAux;
            posPlayerY = posPlayerYAux;
            death = deathAux;
        }
    }
}
