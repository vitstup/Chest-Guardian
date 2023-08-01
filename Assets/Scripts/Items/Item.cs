using UnityEngine;

public abstract class Item
{
    [field: SerializeField] public string itemName { get; protected set; }
    [field: SerializeField] public Sprite sprite { get; private set; }
    [field: SerializeField] public Rarity rarity { get; private set; }

    public Item(Rarity rarity, Sprite sprite, string itemName)
    {
        this.rarity = rarity;
        this.sprite = sprite;
        this.itemName = itemName;
    }

    public abstract void AddToInventory(Inventory inventory);

    public abstract Item GetEquipedFromInventory(Inventory inventory);

    public abstract int GetPointsAmountAfterDropping();

    public abstract Stats GetStats();

    public abstract string GetStatsDescription();
}