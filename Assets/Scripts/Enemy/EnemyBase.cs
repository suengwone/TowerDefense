using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SW.Enemy
{
    [System.Serializable]
    public enum EnemyType
    {
        Boss,
        MidBoss,
        Elite,
        Normal,
    }

    [System.Serializable]
    public enum MoveType
    {
        Air,
        Ground,
    }

    [System.Serializable]
    public enum EnemyState
    {
        Move,
        Stun,
        Dead,
    }

    public abstract class EnemyBase : MonoBehaviour
    {
        #region Properties
        public EnemyType EnemyType { get; set; }
        public EnemyState EnemyState { get; set; }
        public MoveType EnemyMoveType { get; set; }
        public float HealthPoint { get; set; }
        public float MoveSpeed { get; set; }
        public float DefensePoint { get; set; }
        #endregion

        #region Abstract
        #endregion

        #region Implement
        protected void Die()
        {
            this.gameObject.SetActive(false);
        }
        public void Initial(int startHP, float startSpeed, float startDP)
        {
            HealthPoint = startHP;
            MoveSpeed = startSpeed;
            DefensePoint = startDP;

            EnemyState = EnemyState.Move;
        }

        public object StartMove(List<Vector3> points)
        {
            return StartCoroutine(MoveRoute(points));
        }

        private IEnumerator<int> MoveRoute(List<Vector3> points)
        {
            EnemyState = EnemyState.Move;

            foreach (var endPoint in points)
            {
                // transform.LookAt(endPoint);
                Vector3 startPoint = transform.position;
                float dis = Vector3.Distance(endPoint, startPoint);
                float startTime = Time.time;

                while (transform.position != endPoint)
                {
                    if (EnemyState == EnemyState.Move)
                    {
                        float curTime = Time.time - startTime;

                        if (curTime >= dis / MoveSpeed)
                        {
                            transform.position = endPoint;
                            break;
                        }

                        transform.position = Vector3.MoveTowards(startPoint, endPoint, curTime * MoveSpeed);
                    }
                    else if (EnemyState == EnemyState.Dead)
                    {
                        yield return -1;
                        yield break;
                    }
                }
            }

            yield return -1;
        }
        #endregion
    }
}
