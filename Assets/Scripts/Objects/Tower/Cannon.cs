using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Personal.Objects.Tower
{
    public class Cannon : TowerBase
    {
        public void Initial()
        {
            base.Initial();
            towerType = TowerType.Cannon;
        }

        public override void Attack()
        {
            // TODO
            // Attack Only Ground Enemy
            // Attack with Bomb
            // Attack Delay
            // Splash Damage
        }
    }
}