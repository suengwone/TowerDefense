using System;
using System.Collections.Generic;
using UnityEngine;

namespace Data.Tower
{
    [CreateAssetMenu(fileName = "Tower Data", menuName = "Scriptable Object/Tower Data")]
    public class TowerData : ScriptableObject
    {
        [SerializeField]
        List<TowerProperty> towerList = new ();
    }

    [Serializable]
    public struct TowerProperty
    {
        [SerializeField] private Objects.Tower.TowerProperty.TowerType towerType;
        public Objects.Tower.TowerProperty.TowerType TowerType
        {
            get => towerType;
        }

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