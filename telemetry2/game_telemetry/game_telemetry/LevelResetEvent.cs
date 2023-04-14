using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_telemetry
{
    class LevelResetEvent
    {
        //Posicion ANTES del reinicio
        int posPlayerX;
        int posPlayerY;
        int actualLevel;
        protected LevelResetEvent(EventType type, string session_id, int posPlayerXAux, int posPlayerYAux, int actualLevelAux) : base(type, session_id)
        {
            posPlayerX = posPlayerXAux;
            posPlayerY = posPlayerYAux;
            actualLevel = actualLevelAux;
        }
    }
}