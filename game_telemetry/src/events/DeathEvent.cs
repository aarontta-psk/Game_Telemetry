using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_telemetry
{
    class DeathEvent:TelemetryEvent
    {
        public enum deathType { FELL, DMG};

        public int posPlayerX;
        public int posPlayerY;
        public deathType death;
        //ID DE SECCION QUE NO SE COMO HACER ESTO

        protected DeathEvent(EventType type, string session_id, int posPlayerXAux, int posPlayerYAux, deathType deathAux) : base(type, session_id)
        {
            posPlayerX = posPlayerXAux;
            posPlayerY = posPlayerYAux;
            death = deathAux;
        }
    }
}
