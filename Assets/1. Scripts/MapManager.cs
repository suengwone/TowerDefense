using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapManager : MonoBehaviour
{
    public void LoadSelectedMap(int mapIdx)
    {
        SceneManager.LoadScene(mapIdx);

        // Loading (Delay 10 Second)
        // Add ad or tips
    }
}
