using System;
using UnityEngine;

namespace Objects.Enemy
{
    using Common;
    using Data.Enemy;
    using Data;
    using Unity.Properties;

    public abstract class EnemyBase
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
        protected private float speedPoint;
        public float SpeedPoint
        {
            get => speedPoint;
            set => speedPoint = value;
        }
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
            // this.healthPoint    = enemyData.healthPoint;
            // this.defensePoint   = enemyData.defensePoint;
            // this.attackPoint    = enemyData.attackPoint;
            this.speedPoint     = enemyData.speedPoint;
            this.State          = EnemyState.Move;
        }
        #endregion
    }
}
