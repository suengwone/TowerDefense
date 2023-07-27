using UnityEngine;

namespace SW.Tower
{
    public abstract class TowerBase : MonoBehaviour
    {
        public enum towerType
        {
            // only ground
            Cannon,
            // both ground, air
            Laser,
            // only air
            Missile
        }

        public enum passiveType
        {
            // attack count + 1
            countUp,
            // attack range +
            rangeUp,
            // attack speed +
            speedUp,
            // attack damge +
            damageUp,
            // monster move Speed - (attacked monsters, for n seconds)
            speedDown,
            // monster defense - (attacked monsters, for n seconds)
            defenseDown,
            // monster HP - (wave start, all monsters)
            HPDown
        }

    #region Property
        private towerType thisTtype;
        public towerType ThisTtype
        {
            get { return ThisTtype; }
            set { this.ThisTtype = value; }
        }
        private passiveType thisPtype;
        public passiveType ThisPtype
        {
            get { return thisPtype; }
            set { this.thisPtype = value; }
        }
        private float damage;
        public float Damage
        {
            get { return damage; }
            set { this.damage = value; }
        }
        private float attackRange;
        public float AttackRange
        {
            get { return attackRange; }
            set { this.attackRange = value; }
        }
        private float attackSpeed;
        public float AttackSpeed
        {
            get { return attackSpeed; }
            set { this.attackSpeed = value; }
        }
        private int attackCount;
        public int AttackCount
        {
            get { return attackCount;}
            set { this.attackCount = value; }
        }
        private int cost;
        public int Cost
        {
            get { return cost; }
            set { this.cost = value; }
        }
    #endregion
    #region Abstract
        public abstract void Attack();
    #endregion
    #region Implement
        public void Initial(float startDamage, float startAttackRange, float startAttackSpeed, float startAttackCount)
        {

        }

        public void Upgrade(passiveType pType, int plusCount)
        {
            this.AttackCount += plusCount;
        }
        public void Upgrade (passiveType pType, float plusAmount)
        {
            switch(pType)
            {
                case passiveType.damageUp:
                    this.Damage *= plusAmount;
                    break;
                case passiveType.speedUp:
                    this.AttackSpeed *= plusAmount;
                    break;
                case passiveType.rangeUp:
                    this.AttackRange *= plusAmount;
                    break;
                default:
                    break;
            }
        }
    #endregion
    }
}