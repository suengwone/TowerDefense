namespace Objects.Common
{
    public interface IDamageable
    {
        public float MaxHealthPoint     { get; set; }
        public float CurrentHealthPoint { get; set; }
        public float DefensePoint       { get; set; }
    }
}