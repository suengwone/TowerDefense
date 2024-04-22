namespace Personal.Objects.Common
{
    public interface IAttackable
    {
        float AttackCount { get; set; }
        float AttackRange { get; set; }
        float AttackSpeed { get; set; }

        void Attack();
    }
}