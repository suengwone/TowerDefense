using UnityEngine;

namespace Personal.Data.Tower
{
    [CreateAssetMenu(fileName = "Tower Data", menuName = "Scriptable Object/Tower Data")]
    public class TowerData : ScriptableObject
    {
        [SerializeField] private float attackRange;
        public float AttackRange
        {
            get => attackRange;
            set => attackRange = value;
        }

        [SerializeField] private float attackSpeed;
        public float AttackSpeed
        {
            get => attackSpeed;
            set => attackSpeed = value;
        }

        [SerializeField] private int attackCount;
        public int AttackCount
        {
            get => attackCount;
            set => attackCount = value;
        }
    }
}