[System.Serializable]
public class ItemInstance
{
    public ItemData itemType;
    public int durabulity;
    public int raity;

    public ItemInstance(ItemData itemData)
    {
        itemType = itemData;
        durabulity = itemData.startingDurability;
        raity = itemData.rarity;
    }
}