[System.Serializable]
public class WeaponGenerator : BaseItemGenerator
{
    public override Item GetItem()
    {
        var descriptor = GetRandomDescriptor();
        return new Weapon(GetRandomRarity(), descriptor.sprite, descriptor.itemName);
    }
}