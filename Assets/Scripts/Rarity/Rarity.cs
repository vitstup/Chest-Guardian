using UnityEngine;

[System.Serializable]
public class Rarity
{
    [field: SerializeField] public string rarityName { get; private set; }
    [field: SerializeField] public Color color { get; private set; }
    [field: SerializeField, Range(0f, 1f)] public float spawnChance { get; private set; }

    [field: SerializeField, Range(1, 10)] public int minValue { get; private set; }
    [field: SerializeField, Range(1, 15)] public int maxValue { get; private set; }
}