using UnityEngine;

[System.Serializable]   
public class Shield : Item
{
    [field: SerializeField] public int defense { get; private set; }

    public Shield(Rarity rarity, Sprite sprite, string itemName) : base(rarity, sprite, itemName)
    {
        defense = Random.Range(rarity.minValue, rarity.maxValue);
    }

    public override void AddToInventory(Inventory inventory)
    {
        inventory.SetShield(this);
    }

    public override Item GetEquipedFromInventory(Inventory inventory)
    {
        return inventory.shield;
    }

    public override int GetPointsAmountAfterDropping()
    {
        return defense;
    }

    public override Stats GetStats()
    {
        return new Stats() { defense = defense };
    }

    public override string GetStatsDescription()
    {
        return "Defense " + defense;
    }
}