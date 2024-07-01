namespace Personal.Objects.Common
{
    public interface IDamaageable
    {
        public float MaxHealthPoint     { get; set; }
        public float CurrentHealthPoint { get; set; }
        public float DefensePoint       { get; set; }
    }
}