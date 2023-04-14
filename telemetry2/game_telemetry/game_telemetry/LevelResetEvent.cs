using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_telemetry
{
    class LevelResetEvent : TelemetryEvent
    {
        //Posicion ANTES del reinicio
        public int posPlayerX;
        public int posPlayerY;
        public int actualLevel;
        protected LevelResetEvent(EventType type, string session_id, int posPlayerXAux, int posPlayerYAux, int actualLevelAux) : base(type, session_id)
        {
            posPlayerX = posPlayerXAux;
            posPlayerY = posPlayerYAux;
            actualLevel = actualLevelAux;
        }
    }
}