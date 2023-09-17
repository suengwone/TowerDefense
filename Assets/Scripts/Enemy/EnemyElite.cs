namespace SW.Enemy
{
    public class EnemyElite : EnemyBase, IDamage
    {
        private void Awake()
        {
            EnemyType = EnemyType.Elite;
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
