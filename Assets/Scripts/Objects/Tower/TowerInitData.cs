namespace Personal.Objects.Tower
{
    public class TowerInitData
    {
        public enum TowerType
        {
            None,
            Cannon,
            Missile,
            Laser,
        }

        public enum PassiveType
        {
            // Attack Count + 1
            CountUp,
            // Attack Range Up
            RangeUp,
            // Atack Speed Up
            SpeedUp,
            // Attack Point Up
            AttackUp
        }
    }
}
