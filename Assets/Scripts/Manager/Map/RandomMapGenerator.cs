using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Manager.Map
{
    public class RandomMapGenerator : MonoBehaviour
    {
        private List<List<Tile>> tiles;

        // Create Tile Map (N X M)
        private void InitialTiles(int width, int hieght)
        {
            tiles = new (width);

            for (int i=0; i<width; i++)
            {
                tiles[i] = new (hieght);
            }
        }
    }

    public struct Tile
    {
        public bool isGround;
    }
}