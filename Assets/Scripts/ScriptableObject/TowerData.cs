using UnityEngine;

namespace Personal.Data.Tower
{
    [CreateAssetMenu(fileName = "Tower Data", menuName = "Scriptable Object/Tower Data")]
    public class TowerData : ScriptableObject
    {
        [SerializeField]
        private int cost;
        public int Cost => cost;
        [SerializeField]
        private float damage;
        public float Damage => damage;
        [SerializeField]
        private float attackRange;
        public float AttackRange => attackRange;
        [SerializeField]
        private float attackSpeed;
        public float AttackSpeed => attackSpeed;
        [SerializeField]
        private int attackCount;
        public int AttackCount => attackCount;
        [SerializeField]
        private TowerType attckType;
        public TowerType AttackType => attckType;
    }
    public enum TowerType
    {
        // only ground
        Cannon,
        // only air
        Missile,
        // both ground, air
        Laser,
    }
}
