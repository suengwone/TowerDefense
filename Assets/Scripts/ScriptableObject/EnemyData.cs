using System;

namespace Personal.Data.Enemy
{
    [Serializable]
    public class EnemyData
    {
        public enum EnemyType
        {
            Normal,
            Elite,
            MidBoss,
            Boss,
        }
        public enum MoveType
        {
            Ground,
            Air,
        }
        
        public float healthPoint;
        public float defensePoint;
        public float speedPoint;
        public EnemyType enemyType;
        public MoveType enemyMoveType;
    }
}
