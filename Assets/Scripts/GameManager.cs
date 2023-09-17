using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SW.Enemy;
using SW.Tower;

namespace SW.Manager
{
    public class GameManager : MonoBehaviour
    {
        EnemyManager enemyManager;
        TowerManager towerManager;
        public MapManager mapManager;
        public Transform pointsParent;

        public List<Button> towerInstantiateBtnList;
        public Button startBtn;
        public List<Vector3> points;
        TMPro.TMP_Text waveUI;

        private void Awake()
        {
            enemyManager = GameObject.FindWithTag("Manager").GetComponentInChildren<EnemyManager>();
            startBtn.onClick.AddListener(() => MapSelectBtn(0));
            waveUI = GameObject.Find("WaveNum").GetComponent<TMPro.TMP_Text>();
        }

        public void GameStart()
        {
            points = new List<Vector3>();

            for(int i=0; i<pointsParent.childCount; i++)
            {
                points.Add(pointsParent.GetChild(i).GetComponent<RectTransform>().position);
            }

            waveUI.text = "Wave 1";
            enemyManager.StartWave(1, points);
        }

        void MapSelectBtn(int mapIdx)
        {
            // Load Selected Map
            // mapManager.LoadSelectedMap(mapIdx);

            // Complete Load Selected Map
            GameStart();
        }

        // Info Manager
        // Load User Info in Server (App Start)
        // Save User Info in Server (Event)
    }
}