using System;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    [CreateAssetMenu(fileName = "Base Data", menuName = "Scriptable Object/Base Data")]
    public class BaseData : ScriptableObject
    {
        public List<DataInfo> datas;
    }

    [Serializable]
    public class DataInfo
    {
        public string dataName;
        public string path;
    }
}
