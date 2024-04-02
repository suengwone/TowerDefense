using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Personal.Objects
{
    public class ObjectPool
    {
        private Stack<GameObject> normalPool;
        private Stack<GameObject> elitePool;
        private Stack<GameObject> midBossPool;
        private Stack<GameObject> bossPool;
    }
}
