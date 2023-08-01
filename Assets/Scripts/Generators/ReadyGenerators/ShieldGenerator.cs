[System.Serializable]
public class ShieldGenerator : BaseItemGenerator
{
    public override Item GetItem()
    {
        var descriptor = GetRandomDescriptor();
        return new Shield(GetRandomRarity(), descriptor.sprite, descriptor.itemName);
    }
}