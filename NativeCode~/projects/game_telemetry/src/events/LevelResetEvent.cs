namespace game_telemetry
{
    public class LevelResetEvent : TelemetryEvent
    {
        //Posicion ANTES del reinicio
        public int PosPlayerX { get; private set; }
        public int PosPlayerY { get; private set; }
        public int CurrentLevel { get; private set; }

        public LevelResetEvent(EventType type, int posPlayerX, int posPlayerY, int currentLevel) : base(type)
        {
            PosPlayerX = posPlayerX;
            PosPlayerY = posPlayerY;
            CurrentLevel = currentLevel;
        }
    }
}