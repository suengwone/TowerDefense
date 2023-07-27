public interface ITower
{
    public towerType tType {get;}
    public PassiveType pType {get;}
    public int damage {get; set;}
    public float attackRange {get; set;}
    public float attackSpeed {get; set;}
    public int attackCount {get; set;}
    public int cost {get;}
    void Attack();
}

public enum towerType
{
    // only ground
    Cannon,
    // both ground, air
    Laser,
    // only air
    Missile
}

public enum PassiveType
{
    // attack count + 1
    countUp,
    // attack range +
    rangeUp,
    // attack speed +
    speedUp,
    // attack damge +
    damageUp,
    // monster move Speed - (attacked monsters, for n seconds)
    speedDown,
    // monster defense - (attacked monsters, for n seconds)
    defenseDown,
    // monster HP - (wave start, all monsters)
    HPDown
}