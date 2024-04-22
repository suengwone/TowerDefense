using UnityEngine;

namespace Personal.Objects.Common
{
    public class BaseProperty : MonoBehaviour
    {
        [SerializeField] protected private float healthPoint;
        public float HealthPoint
        {
            get => healthPoint;
            set => healthPoint = value;
        }

        [SerializeField] protected private float defensePoint;
        public float DefensePoint
        {
            get => defensePoint;
            set => defensePoint = value;
        }

        [SerializeField] protected private float attackPoint;
        public float AttackPoint
        {
            get => attackPoint;
            set => attackPoint = value;
        }
    }
}