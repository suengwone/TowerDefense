using UnityEngine;

namespace Objects.Tower
{
    using Common;

    public abstract class TowerBase : MonoBehaviour, IAttackable, IUpgradable, IDamageable
    {
        public int Cost { get; }
        float IAttackable.AttackCount { get; set; }
        float IAttackable.AttackRange { get; set; }
        float IAttackable.AttackSpeed { get; set; }
        float IAttackable.AttackPoint { get; set; }
        float IDamageable.MaxHealthPoint { get; set; }
        float IDamageable.CurrentHealthPoint { get; set; }
        float IDamageable.DefensePoint { get; set; }

        #region Abstract

        public void Attack(IDamageable property)
        {
            throw new System.NotImplementedException();
        }
        #endregion

        #region Implement
        public void Initial()
        {
            
        }
        public void Upgrade()
        {
            // switch (passiveType)
            // {
            //     case PassiveType.CountUp:
            //         AttackCount += 1;
            //         break;
            //     case PassiveType.RangeUp:
            //         AttackRange += 1;
            //         break;
            //     case PassiveType.SpeedUp:
            //         AttackSpeed += 1;
            //         break;
            //     case PassiveType.AttackUp:
            //         AttackPoint += 1;
            //         break;
            // }
        }
        #endregion
    }
}
