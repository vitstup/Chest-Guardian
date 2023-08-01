public class Stats
{
    public int damage { get; set; }   
    public int defense { get; set; }
    public int health { get; set; }

    public int GetSumm()
    {
        return damage + defense + health;
    }

    public static Stats operator +(Stats a, Stats b)
    {
        return new Stats()
        {
            damage = a.damage + b.damage,
            defense = a.defense + b.defense,
            health = a.health + b.health
        };
    }

    public static bool operator >(Stats a, Stats b)
    {
        return a.GetSumm() > b.GetSumm();
    }

    public static bool operator <(Stats a, Stats b)
    {
        return a.GetSumm() < b.GetSumm();
    }
}