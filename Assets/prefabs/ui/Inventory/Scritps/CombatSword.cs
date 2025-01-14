using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatSword : MonoBehaviour
{
    [SerializeField] private DynamicInventory inventory;
    public int damage;
    [SerializeField] private ChangeItem player;
    // Start is called before the first frame update

    public void DecreaseDurability()
    {
        var sword = inventory.items[inventory.lastItemIndex];
        Debug.Log(sword.durabulity + " Before");
        inventory.RemoveDurability(sword, 1);
        Debug.Log(sword.durabulity + " After");
        if (sword.durabulity == 0)
        {
            inventory.RemoveItem(sword);
            if (inventory.items.Count > 0)
            {
                if (inventory.lastItemIndex >= inventory.items.Count)
                {
                    player.ChangeSword(-1);
                }
                else
                {
                    player.ChangeSword(0);
                }
                sword = inventory.items[inventory.lastItemIndex];
                damage = sword.Damage;
            }
        }
        else
        {
            player.ChangeText();
        }
    }
}
