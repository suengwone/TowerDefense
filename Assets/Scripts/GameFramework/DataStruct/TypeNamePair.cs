using System;
using System.Runtime.InteropServices;

namespace GameFramework
{
    [StructLayout(LayoutKind.Auto)]
    internal struct TypeNamePair : IEquatable<TypeNamePair>
    {
        private readonly Type m_Type;
        public Type Type { get => m_Type; }

        private readonly string m_Name;
        public string Name { get => m_Name; }

        public TypeNamePair(Type type)
            : this(type, string.Empty) {}

        public TypeNamePair(Type type, string name)
        {
            if (type == null)
            {
                throw new Exception();
            }

            m_Type = type;
            m_Name = name ?? string.Empty;
        }

        public override string ToString()
        {
            if(m_Type == null)
            {
                throw new Exception();
            }

            string typeName = m_Type.FullName;
            return string.IsNullOrEmpty(m_Name) ? typeName : string.Format("{0}.{1}", typeName, m_Name);
        }

        public override int GetHashCode()
            => m_Type.GetHashCode() ^ m_Name.GetHashCode();

        public override bool Equals(object obj)
            => obj is TypeNamePair && Equals((TypeNamePair)obj);

        public bool Equals(TypeNamePair value)
            => m_Type == value.m_Type && m_Name == value.m_Name;

        public static bool operator ==(TypeNamePair a, TypeNamePair b)
            => a.Equals(b);

        public static bool operator != (TypeNamePair a, TypeNamePair b)
            => !(a==b);
    }
}