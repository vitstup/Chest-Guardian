using UnityEngine;

[System.Serializable]
public class Helmet : Item
{
    [field: SerializeField] public int hp { get; private set; }

    public Helmet(Rarity rarity, Sprite sprite, string itemName) : base(rarity, sprite, itemName)
    {
        hp = Random.Range(rarity.minValue, rarity.maxValue);
    }

    public override void AddToInventory(Inventory inventory)
    {
        inventory.SetHelmet(this);
    }

    public override Item GetEquipedFromInventory(Inventory inventory)
    {
        return inventory.helmet;
    }

    public override int GetPointsAmountAfterDropping()
    {
        return hp;
    }

    public override Stats GetStats()
    {
        return new Stats() { health = hp };
    }

    public override string GetStatsDescription()
    {
        return "Health " + hp;
    }
}