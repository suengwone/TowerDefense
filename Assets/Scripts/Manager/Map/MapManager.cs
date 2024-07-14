using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Manager.Map
{
    public class MapManager : MonoBehaviour
    {
        [SerializeField] private Transform centerTarget;

        public void LoadSelectedMap(int mapIdx)
        {
            SceneManager.LoadScene(mapIdx);

            // Loading (Delay 10 Second)
            // Add ad or tips
        }
    }
}