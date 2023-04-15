namespace game_telemetry
{
    public class LevelResetEvent : TelemetryEvent
    {
        //Posicion ANTES del reinicio
        public int posPlayerX;
        public int posPlayerY;
        public int actualLevel;
        public LevelResetEvent(EventType type, int posPlayerXAux, int posPlayerYAux, int actualLevelAux) : base(type)
        {
            posPlayerX = posPlayerXAux;
            posPlayerY = posPlayerYAux;
            actualLevel = actualLevelAux;
        }
    }
}