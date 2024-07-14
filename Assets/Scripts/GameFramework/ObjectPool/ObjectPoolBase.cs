using System;

namespace GameFramework.ObjectPool
{
    public abstract class ObjectPoolBase
    {
        private readonly string m_Name;
        public string Name { get => m_Name; }

        public ObjectPoolBase()
            : this(null)
        {
        }

        public ObjectPoolBase(string name)
        {
            m_Name = name ?? string.Empty;
        }
        
        public abstract Type ObjectType { get; }
        
        public string FullName { get => new TypeNamePair(ObjectType, m_Name).ToString(); }
        
        public abstract int Count { get; }

        public abstract int CanReleaseCount { get; }

        public abstract bool AllowMultiSpawn  { get; }

        public abstract float AutoReleaseInterval { get; set; }

        public abstract int Capacity { get; set; }

        public abstract int Priority { get; set; }

        public abstract void Release();

        public abstract void Release(int toReleaseCount);

        public abstract void ReleaseAllUnused();

        public abstract ObjectInfo[] GetAllObjetInfos();

        internal abstract void Update(float elapseSeconds, float realElapseSeconds);

        internal abstract void Shutdown();
    }
}
