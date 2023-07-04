using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TowerBase : ITowerBehavior
{
    towerType tType;
    public int damage;
    public float attackRange;
    public float attackSpeed;
    public int cost;

    private Transform target;

    public abstract void Attack();
}