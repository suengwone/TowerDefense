public interface IUpgradable
{
    int Level { get; set; }
    int Cost { get; }
    void Upgrade();
}
