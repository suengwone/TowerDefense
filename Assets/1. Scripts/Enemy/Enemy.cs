using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SW.Enemy
{
    public class Enemy : EnemyBase, IDamage
    {
        public override void Die()
        {
            throw new System.NotImplementedException();
        }

        public override void ArriveEndPoint()
        {
            throw new System.NotImplementedException();
        }

        void IDamage.Damage(float damage)
        {

        }
    }
}
