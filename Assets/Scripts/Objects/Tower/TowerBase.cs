using UnityEngine;

namespace Personal.Objects.Tower
{
    using Common;
    using Data.Tower;

    public abstract class TowerBase : BaseProperty
    {
        [SerializeField]
        private int cost;
        public int Cost => cost;

        #region Abstract
        public virtual void Attack()
        {
            Debug.Log("Attack");
        }
        public virtual void Upgrade()
        {
            Debug.Log("Upgrade");
        }
        #endregion

        #region Implement
        public void Initial(TowerData towerData)
        {
            // Random Tower Type

            // Random Passive


        }
        #endregion
    }
}
