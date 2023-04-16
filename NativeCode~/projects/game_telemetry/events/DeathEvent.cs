namespace game_telemetry
{
    public class DeathEvent :TelemetryEvent
    {
        public enum deathType { FELL, DMG};

        public int posPlayerX;
        public int posPlayerY;
        public deathType death;
        //ID DE SECCION QUE NO SE COMO HACER ESTO

        public DeathEvent(EventType type, int posPlayerXAux, int posPlayerYAux, deathType deathAux) : base(type)
        {
            posPlayerX = posPlayerXAux;
            posPlayerY = posPlayerYAux;
            death = deathAux;
        }
    }
}
