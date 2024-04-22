using UnityEngine;

namespace Personal.Objects.Tower
{
    using Common;

    public class TowerProperty : BaseProperty
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

        [SerializeField] protected private TowerType towerType;
        public TowerType CurTowerType => towerType;

        [SerializeField] protected private PassiveType passiveType;
        public PassiveType CurPassiveType => passiveType;

        public void SetRandomType()
        {
            passiveType = (PassiveType)Random.Range(0, 4);
        }
    }
}
