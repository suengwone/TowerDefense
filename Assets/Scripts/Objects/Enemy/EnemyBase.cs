using System;
using UnityEngine;

namespace Personal.Objects.Enemy
{
    using Data.Enemy;
    
    public abstract class EnemyBase : MonoBehaviour
    {
        [Serializable]
        public enum EnemyState
        {
            None,
            Move,
            Dead,
        }
        #region Properties
        private EnemyState state = EnemyState.None;
        public EnemyState State
        { 
            get => state; 
            set
            {
                if(state == value)
                    return;

                state = value;
                switch (state)
                {
                    case EnemyState.Move:
                        Move();
                        break;
                    case EnemyState.Dead:
                        Die();
                        break;
                    default:
                        break;
                }
            }
        }
        public float healthPoint    { get; set; }
        public float defensePoint   { get; set; }
        public float speedPoint     { get; set; }
        #endregion

        #region Abstract
        public virtual void Move()
        {
            Debug.Log("Move");
        }
        public virtual void Die()
        {
            Debug.Log("Die");
        }
        #endregion

        #region Implement
        public void Initial(EnemyData enemyData)
        {
            this.healthPoint    = enemyData.healthPoint;
            this.defensePoint   = enemyData.defensePoint;
            this.speedPoint     = enemyData.speedPoint;
            this.State          = EnemyState.Move;
        }
        #endregion
    }
}
