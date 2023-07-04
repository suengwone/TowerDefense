using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Manager
{
    // Enemy Manager
    // Enemy Instantiate in Line
    // Set Enemy Properties
    // Line Move
    // Boss Line
    public class EnemyManager
    {
        List<Enemy> enemyList = new List<Enemy>();

        public void InstantiateEnemy(int _enemyCnt)
        {
            // set enemy property in _enemyCnt

            for(int i=0; i<_enemyCnt; i++)
            {
                Enemy enemy = new Enemy();
                // setting
                enemy.setRandomSettings();
                enemyList.Add(enemy);
            }
            
            for(int i=0; i<_enemyCnt; i++)
            {
                enemyList[i].startLine();
                // delay
            }
        }
    }
}
