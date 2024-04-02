using System.Collections.Generic;
using UnityEngine;

namespace Personal.Data.Game.Stage
{
    using Enemy;

    [CreateAssetMenu(fileName = "Enemy Data", menuName = "Scriptable Object/Enemy Data")]
    public class StageDataSO : ScriptableObject
    {
        [SerializeField] private int normalCount;
        public int NormalCount { get; private set; }
        [SerializeField] private int eliteCount;
        public int EliteCount { get; private set; }
        [SerializeField] private int midBossCount;
        public int MidBossCount { get; private set; }
        [SerializeField] private int bossCount;
        public int BossCount { get; private set; }
        public List<EnemyData> WaveDatas;
    }
}