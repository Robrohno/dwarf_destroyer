using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu]
public class DynamicInventory : ScriptableObject
{
    public int maxItems = 10; 
    public List<ItemInstance> items = new();

    public bool AddItem(ItemInstance itemToAdd)
    {
        // Adds a new item if the inventory has space
        if (items.Count < maxItems)
        {
            items.Add(itemToAdd);
            return true;
        }

        Debug.Log("No space in the inventory");
        return false;
    }

    public bool RemoveItem(ItemInstance itemToRemove)
    {
        // Removes an item if it exists in the inventory
        if (items.Contains(itemToRemove))
        {
            items.Remove(itemToRemove);
            return true;
        }

        Debug.Log("Item not found in the inventory");
        return false;
    }

    public bool AddDurability(ItemInstance item, int durabilityToAdd)
    {
        // Adds durability to an item if it exists in the inventory
        if (items.Contains(item))
        {
            item.durabulity += durabilityToAdd;
            return true;
        }
        else {
            AddItem(item);
            return true;
        }
    }
    public bool RemoveDurability(ItemInstance item, int durabilityToRemove)
    {
        // Removes durability from an item if it exists in the inventory
        if (items.Contains(item))
        {
            item.durabulity -= durabilityToRemove;
            return true;
        }

        Debug.Log("Item not found in the inventory");
        return false;
    }
}