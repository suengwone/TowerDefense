using Personal.Data.Tower;
using UnityEngine;

namespace Personal.Objects.Tower
{
    public abstract class TowerBase : MonoBehaviour
    {
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
            
        }
        #endregion
    }
}
