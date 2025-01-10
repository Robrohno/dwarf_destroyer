using UnityEngine;

[CreateAssetMenu]
public class ItemData : ScriptableObject
{
    public string itemName;
    public Sprite itemIcon;
    public string itemDescription;
    public int startingDurability = 100;
    public int damage = 10;
    public int rarity = 1;
}
