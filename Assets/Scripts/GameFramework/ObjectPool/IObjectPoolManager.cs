using System;
using System.Collections.Generic;

namespace GameFramework.ObjectPool
{
    public interface IObjectPoolManager
    {
        int Count { get; }

        bool HasObjectPool<T>() where T : ObjectBase;

        bool HasObjectPool(Type objectType);

        bool HasObjectPool<T>(string name) where T : ObjectBase;

        bool HasObjectPool(Type objectType, string name);

        bool HasObjectPool(Predicate<ObjectBase> condition);

        IObjectPool<T> GetObjectPool<T>() where T : ObjectBase;

        ObjectPoolBase GetObjectPool(Type objectType);

        IObjectPool<T> GetObjectPool<T>(string name) where T : ObjectBase;

        ObjectPoolBase GetObjectPool(Type objectType, string name);

        ObjectPoolBase GetObjectPool(Predicate<ObjectPoolBase> condition);

        ObjectPoolBase[] GetObjectPools(Predicate<ObjectPoolBase> condition);

        void GetObjectPools(Predicate<ObjectPoolBase> condition, List<ObjectPoolBase> results);

        ObjectPoolBase[] GetAllObjectPools();

        void GetAllObjectPools(List<ObjectPoolBase> results);

        
    }
}