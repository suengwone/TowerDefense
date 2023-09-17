namespace SW.Enemy
{
    public class EnemyNormal : EnemyBase, IDamage
    {
        private void Awake()
        {
            EnemyType = EnemyType.Normal;
            EnemyState = EnemyState.Dead;
        }
        private void OnDisable()
        {
            EnemyState = EnemyState.Dead;
        }
        void IDamage.Damage(float damage)
        {
            HealthPoint -= damage;
        }
    }
}
