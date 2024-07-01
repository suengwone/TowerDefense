using UnityEngine;

namespace Personal.Objects.Tower
{
    public class TowerProperty
    {
        public enum TowerType
        {
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
        public enum TowerState
        {
            Idle,
            Attack,
            Upgrade,
            Skill,
            Damage,
            Die,
        }
    }
}
