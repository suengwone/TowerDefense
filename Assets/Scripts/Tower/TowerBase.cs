using UnityEngine;

namespace SW.Tower
{
    public abstract class TowerBase : MonoBehaviour
    {
        public enum TowerType
        {
            // only ground
            Cannon,
            // both ground, air
            Laser,
            // only air
            Missile
        }

        public enum PassiveType
        {
            // attack count + 1
            CountUp,
            // attack range +
            RangeUp,
            // attack speed +
            SpeedUp,
            // attack damage +
            DamageUp,
            // monster move Speed - (attacked monsters, for n seconds)
            SpeedDown,
            // monster defense - (attacked monsters, for n seconds)
            DefenseDown,
            // monster HP - (wave start, all monsters)
            HPDown
        }

        #region Properties
        public TowerType ThisType { get; set; }
        public PassiveType ThisPtype { get; set; }
        public float Damage { get; set; }
        public float AttackRange { get; set; }
        public float AttackSpeed { get; set; }
        public int AttackCount { get; set; }
        public int Cost { get; set; }
        #endregion

        #region Abstract
        public abstract void Attack();
        #endregion

        #region Implement
        public void Initial(float startDamage, float startAttackRange, float startAttackSpeed, int startAttackCount)
        {
            Damage = startDamage;
            AttackRange = startAttackRange;
            AttackSpeed = startAttackSpeed;
            AttackCount = startAttackCount;
        }

        public void Upgrade(PassiveType pType, int plusCount)
        {
            AttackCount += plusCount;
        }

        public void Upgrade(PassiveType pType, float plusAmount)
        {
            switch (pType)
            {
                case PassiveType.DamageUp:
                    Damage *= plusAmount;
                    break;
                case PassiveType.SpeedUp:
                    AttackSpeed *= plusAmount;
                    break;
                case PassiveType.RangeUp:
                    AttackRange *= plusAmount;
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}
