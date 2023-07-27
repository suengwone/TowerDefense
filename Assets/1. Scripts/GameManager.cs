using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Manager
{
    public class GameManager : MonoBehaviour
    {
        PlayManager playManager = new PlayManager();
        EnemyManager enemyManager = new EnemyManager();
        TowerManager towerManager = new TowerManager();
        public MapManager mapManager;

        public Button towerInstantiateBtn;

        private void Start()
        {
            towerInstantiateBtn.onClick.AddListener(() => towerManager.InstantiateRandomTower());   
            towerInstantiateBtn.gameObject.SetActive(false);
        }

        void GameStart()
        {
            playManager.startGame(10, 10);
            // enemyManager.InstantiateEnemy(10);

            towerInstantiateBtn.gameObject.SetActive(true);
        }

        void MapSelectBtn(int mapIdx)
        {
            // Load Selected Map
            mapManager.LoadSelectedMap(mapIdx);

            // Complete Load Selected Map
            GameStart();
        }

        // Info Manager
        // Load User Info in Server (App Start)
        // Save User Info in Server (Event)
    }
}