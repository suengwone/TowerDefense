using System;
using System.Runtime.InteropServices;

namespace GameFramework.ObjectPool
{
    [StructLayout(LayoutKind.Auto)]
    public struct ObjectInfo
    {
        private readonly string m_Name;
        public string Name { get => m_Name; }

        private readonly bool m_Locked;
        public bool Locked { get => m_Locked; }

        private readonly bool m_CustomCanReleaseFlag;
        public bool CustomCanReleaseFlag { get => m_CustomCanReleaseFlag; }

        private readonly int m_Priority;
        public int Priority { get => m_Priority; }

        private readonly DateTime m_LastUseTime;
        public DateTime LastUseTime { get => m_LastUseTime; }

        private readonly int m_SpawnCount;
        public int SpawnCount { get => m_SpawnCount; }

        public bool IsInUse { get => m_SpawnCount > 0; }

        public ObjectInfo(string name, bool locked, bool customCanReleaseFlag, int priority, DateTime lastUseTime, int spawnCount)
        {
            m_Name = name;
            m_Locked = locked;
            m_CustomCanReleaseFlag = customCanReleaseFlag;
            m_Priority = priority;
            m_LastUseTime = lastUseTime;
            m_SpawnCount = spawnCount;
        }

    }
}