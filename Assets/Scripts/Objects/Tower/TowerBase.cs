using UnityEngine;

namespace Personal.Objects.Tower
{
    using Common;

    public abstract class TowerBase : TowerProperty, IAttackable, IUpgradable
    {
        public int Cost { get; }
        public int Level { get; set; }
        public float AttackCount { get; set; }
        public float AttackRange { get; set; }
        public float AttackSpeed { get; set; }

        #region Abstract
        public abstract void Attack();
        public abstract void Upgrade();
        #endregion

        #region Implement
        public void Initial()
        {
            // Random Passive
            SetRandomType();
        }
        #endregion
    }
}
