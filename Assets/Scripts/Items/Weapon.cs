using UnityEngine;

[System.Serializable]
public class Weapon : Item
{
    [field: SerializeField] public int damage { get; private set; }

    public Weapon(Rarity rarity, Sprite sprite, string itemName) : base(rarity, sprite, itemName)
    {
        damage = Random.Range(rarity.minValue, rarity.maxValue);
    }

    public override void AddToInventory(Inventory inventory)
    {
        inventory.SetWeapon(this);
    }

    public override Item GetEquipedFromInventory(Inventory inventory)
    {
        return inventory.weapon;
    }

    public override int GetPointsAmountAfterDropping()
    {
        return damage;
    }

    public override Stats GetStats()
    {
        return new Stats() { damage = damage };
    }

    public override string GetStatsDescription()
    {
        return "Damage " + damage;
    }
}