namespace game_telemetry
{
    public class DeathEvent :TelemetryEvent
    {
        public enum DeathType { FELL, DAMAGE};

        public int posPlayerX;
        public int posPlayerY;
        public DeathType death;
        public int section_ID;

        public DeathEvent(EventType type, int posPlayerXAux, int posPlayerYAux, DeathType deathAux, int section_IDAux) : base(type)
        {
            posPlayerX = posPlayerXAux;
            posPlayerY = posPlayerYAux;
            death = deathAux;
            section_ID = section_IDAux;
        }
    }
}
