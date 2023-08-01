using System.Linq;
using UnityEngine;

public abstract class BaseItemGenerator : ItemGenerator
{
    [System.Serializable]
    protected class ItemDescriptor
    {
        [field: SerializeField] public string itemName { get; private set; }
        [field: SerializeField] public Sprite sprite { get; private set; }
    }

    [SerializeField] protected ItemDescriptor[] descriptors;

    protected Rarity[] rarities;

    public void AddRaritiesVariants(Rarity[] rarities)
    {
        this.rarities = rarities;
    }

    protected ItemDescriptor GetRandomDescriptor()
    {
        if (descriptors == null || descriptors.Length == 0) Debug.LogError("Descriptors is empty");

        return descriptors[Random.Range(0, descriptors.Length)];
    }

    protected Rarity GetRandomRarity()
    {
        var rarities = this.rarities.ToList().OrderBy(rarity => rarity.spawnChance).ToList();
        foreach (var rarity in rarities)
        {
            if (Random.Range(0f, 1f) <= rarity.spawnChance) return rarity;
        }
        return rarities.Last();
    }
}