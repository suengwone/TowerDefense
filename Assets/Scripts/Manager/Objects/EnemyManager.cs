using System.Collections.Generic;
using UnityEngine;

namespace Personal.Manager.Objects.Enemy
{
    // Enemy Manager
    // Enemy Instantiate in Line
    // Set Enemy Properties
    // Line Move
    public class EnemyManager : MonoBehaviour
    {
        [SerializeField] private readonly int NormalCount;
        [SerializeField] private readonly int EliteCount;
        [SerializeField] private readonly int MidBossCount;
        [SerializeField] private readonly int BossCount;


        private void Start()
        {
            // instantiate enemy object pool
            // normal 20, elite 10, midboss 1(air), boss 1(ground)
        }

        public void StartWave(int waveIndex)
        {

        }
    }
}
