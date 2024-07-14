using System;
using System.Collections.Generic;

namespace GameFramework.ObjectPool
{
    /// <summary>
    /// Release Filtered Objects
    /// </summary>
    /// <typeparam name="T">Filter Type</typeparam>
    /// <param name="candidateObjects">Object List to Filter</param>
    /// <param name="toReleaseCount">Object Count to Release</param>
    /// <param name="expireTime">Object Expiration Reference Time</param>
    /// <returns>Filtered Object List to Release</returns>
    public delegate List<T> ReleaseObjectFilterCallback<T>(List<T> candidateObjects, int toReleaseCount, DateTime expireTime) where T : ObjectBase;
}