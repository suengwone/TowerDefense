namespace SW.Enemy
{
    public class EnemyBoss : EnemyBase, IDamage
    {
        private void Awake()
        {
            EnemyType = EnemyType.Boss;
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
