[System.Serializable]
public class HelmetGenerator : BaseItemGenerator
{
    public override Item GetItem()
    {
        var descriptor = GetRandomDescriptor();
        return new Helmet(GetRandomRarity(), descriptor.sprite, descriptor.itemName);
    }
}