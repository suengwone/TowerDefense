using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SW.Enemy
{
    public abstract class EnemyBase : MonoBehaviour
    {
        public enum enemyType
        {
            Boss,
            MidBoss,
            Elite,
            Normal,
        }

        public enum enemyState
        {
            Move,
            Stun,
            Dead,
        }

    #region Property
        private enemyType thisEtype;
        public enemyType ThisEtype
        {
            get { return thisEtype; }
            set { this.thisEtype = value; }
        }
        private enemyState thisEstate;
        public enemyState ThisEstate
        {
            get { return thisEstate; }
            set { this.thisEstate = value; }
        }
        private float healthPoint;
        public float HealthPoint
        {
            get { return (int)healthPoint; }
            set { this.healthPoint = value; }
        }
        private float moveSpeed;
        public float MoveSpeed
        {
            get { return moveSpeed; }
            set { this.moveSpeed = value; }
        }
        private float defensePoint;
        public float DefensePoint
        {
            get { return defensePoint; }
            set { this.defensePoint = value; }
        }
    #endregion

    #region Abstract
        public abstract void Die();
        public abstract void ArriveEndPoint();
    #endregion

    #region Implement
        public void Initial(float startHP, float startSpeed, float startDP, Vector3 startPoint)
        {
            this.HealthPoint = startHP;
            this.MoveSpeed = startSpeed;
            this.DefensePoint = startDP;

            this.transform.position = startPoint;
        }

        public void StartMove(List<Vector3> points)
        {
            StartCoroutine(MoveRoute(points));
        }

        private IEnumerator MoveRoute(List<Vector3> points)
        {
            this.ThisEstate = enemyState.Move;
            Vector3 startPoint;
            float dis, curTime, startTime;

            foreach(var endPoint in points)
            {
                this.transform.LookAt(endPoint);
                startPoint = this.transform.position;
                dis = Vector3.Distance(endPoint, startPoint) / this.MoveSpeed;
                startTime = Time.realtimeSinceStartup;

                while(this.transform.position != endPoint)
                {
                    if(this.ThisEstate == enemyState.Move)
                    {
                        curTime = Time.realtimeSinceStartup - startTime;

                        if(curTime >= dis)
                        {
                            this.transform.position = endPoint;
                            break;
                        }

                        this.transform.position = Vector3.Lerp(startPoint, endPoint, curTime / dis);
                    }
                    else if(this.ThisEstate == enemyState.Dead)
                    {
                        yield break;
                    }
                    
                    yield return null;
                }
            }
        }
    #endregion
    }
}