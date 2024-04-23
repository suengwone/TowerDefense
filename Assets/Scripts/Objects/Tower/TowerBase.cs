using UnityEngine;

namespace Personal.Objects.Tower
{
    using Common;

    public abstract class TowerBase : TowerProperty, IAttackable, IUpgradable
    {
        public int Cost { get; }
        public int Level { get; set; } = 1;
        public float AttackCount { get; set; }
        public float AttackRange { get; set; }
        public float AttackSpeed { get; set; }

        #region Abstract
        public abstract void Attack();
        #endregion

        #region Implement
        public void Initial()
        {
            // Random Passive
            SetRandomType();
        }
        public void Upgrade()
        {
            Level += 1;

            switch (passiveType)
            {
                case PassiveType.CountUp:
                    AttackCount += 1;
                    break;
                case PassiveType.RangeUp:
                    AttackRange += 1;
                    break;
                case PassiveType.SpeedUp:
                    AttackSpeed += 1;
                    break;
                case PassiveType.AttackUp:
                    AttackPoint += 1;
                    break;
            }
        }
        #endregion
    }
}
