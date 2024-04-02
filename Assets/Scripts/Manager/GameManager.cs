using System.Collections.Generic;
using Personal.Manager.Objects.Enemy;
using Personal.Manager.Objects.Tower;
using UnityEngine;
using UnityEngine.UI;

namespace Personal.Manager.Game
{
    public class GameManager : MonoBehaviour
    {
        public void GameStart()
        {
            // Generate Random map
            // Start Wave
        }

        private List<Vector3> CreateRandomPoint(int pointCount, Vector3 startPoint, Vector3 endPoint)
        {
            List<Vector3> pointList = new List<Vector3>();

            float horizontalInterval = (endPoint.x - startPoint.x) / (pointCount + 1);
            float verticalInterval = Screen.height * 0.5f * 0.8f;

            for(int i=1; i<=pointCount; i++)
            {
                float randomInterval = Random.Range(-verticalInterval, verticalInterval);
                pointList.Add(new Vector3(startPoint.x + horizontalInterval * i, startPoint.y + randomInterval));
            }

            return pointList;
        }

        // Info Manager
        // Load User Info in Server (App Start)
        // Save User Info in Server (Event)
    }
}