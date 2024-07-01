namespace Personal.Objects.Common
{
    public interface IAttackable
    {
        protected float AttackPoint { get; set; }
        protected float AttackCount { get; set; }
        protected float AttackRange { get; set; }
        protected float AttackSpeed { get; set; }

        void Attack(IDamageable property);
    }
}