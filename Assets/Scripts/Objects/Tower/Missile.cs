using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Personal.Objects.Tower
{
    public class Missile : TowerBase
    {
        public void Initial()
        {
            base.Initial();
            towerType = TowerType.Missile;
        }

        public override void Attack()
        {
            // TODO
            // Attack Only Air Enemy
            // Attack with Missile
            // Attack Delay
            // One Target Damage
        }
    }
}