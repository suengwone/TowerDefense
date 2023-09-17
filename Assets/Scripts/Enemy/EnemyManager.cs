using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SW.Enemy
{
    // Enemy Manager
    // Enemy Instantiate in Line
    // Set Enemy Properties
    // Line Move
    // Boss Line
    public class EnemyManager : MonoBehaviour
    {
        int waveNum;
        public float delayTime = 10000000f;
        public Transform ObjectPool;
        // Default Count Values
        public int normalCount = 20, eliteCount = 10, midBossCount = 1, bossCount = 1;
        Dictionary<string, List<GameObject>> enemiesDic;
        List<Vector3> movePoints;
        int objCounts;

        private void Start()
        {
            enemiesDic = new Dictionary<string, List<GameObject>>();

            // instantiate enemy object pool
            // normal 20, elite 10, midboss 1(air), boss 1(ground)
            InstanceEnemies("Normal", 20);
            InstanceEnemies("Elite", 10);
            InstanceEnemies("MidBoss", 1);
            InstanceEnemies("Boss", 1);
        }

        public void StartWave(int waveNum, List<Vector3> points)
        {
            bool allRight = CheckEnemyCount();

            if(allRight == false)
            {
                // add enemy instances in objectPool
            }


            if(waveNum % 5 != 0)
            {
                // normal wave
                StartCoroutine(ActiveEnemies("Normal", points, 0, 500, 0, 0.5f));
            }
            else
            {
                if(waveNum / 10 == 1)
                {
                    // midBoss wave
                }
                else if(waveNum / 10 == 2)
                {
                    // boss wave
                }
                else
                {
                    // elite wave
                }
            }
        }

        private bool CheckEnemyCount()
        {
            bool isRight = true;

            // check each enemy type count

            return isRight;
        }

        private IEnumerator ActiveEnemies(string enemyCat, List<Vector3> points, int startHP, float startSpeed, float startDP, float delayTime)
        {
            WaitForSecondsRealtime delay = new WaitForSecondsRealtime(delayTime);
            objCounts = 0;

            // per enemy types, active
            foreach(var enemy in enemiesDic[enemyCat])
            {
                objCounts += 1;
                enemy.GetComponent<EnemyBase>().Initial(startHP, startSpeed, startDP);
                enemy.transform.position = points[0];
                enemy.SetActive(true);
                enemy.GetComponent<EnemyBase>().StartMove(points);

                yield return delay;
            }
        }

        private void InstanceEnemies(string enemyName, int count)
        {
            GameObject enemy = Resources.Load<GameObject>("Enemies/" + enemyName);
            enemiesDic[enemyName] = new List<GameObject>();

            for(int i=0; i<count; i++)
            {
                GameObject tempObj = Instantiate(enemy, ObjectPool);
                tempObj.SetActive(false);
                enemiesDic[enemyName].Add(tempObj);
            }
        }
    }
}
