using UnityEngine;

public class ItemsGeneratorManager : MonoBehaviour
{
    [Header("Rarities")]
    [SerializeField] private Rarity[] rarities;

    [Header("Generators")]
    [SerializeField] private WeaponGenerator weaponGenerator;
    [SerializeField] private ShieldGenerator shieldGenerator;
    [SerializeField] private HelmetGenerator helmetGenerator;

    private BaseItemGenerator[] generators;

    private void Start()
    {
        SetGenerators();
        SetRarities();
    }

    private void SetGenerators()
    {
        generators = new BaseItemGenerator[]
        {
            weaponGenerator,
            shieldGenerator,
            helmetGenerator,
            // add other generators here, if needed
        };
    }

    private void SetRarities()
    {
        foreach (var generator in generators)
        {
            generator.AddRaritiesVariants(rarities);
        }
    }

    public Item GenerateItem()
    {
        return generators[Random.Range(0, generators.Length)].GetItem();
    }
}