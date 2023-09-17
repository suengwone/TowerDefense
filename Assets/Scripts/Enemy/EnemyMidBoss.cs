namespace SW.Enemy
{
    public class EnemyMidBoss : EnemyBase, IDamage
    {
        private void Awake()
        {
            EnemyType = EnemyType.MidBoss;
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
