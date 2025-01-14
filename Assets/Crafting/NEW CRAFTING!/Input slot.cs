using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class Inputslot : MonoBehaviour
{
    public Durability sworddurability;
    bool used = false;
    [SerializeField] private SwordCounter counter;
    [SerializeField] private Itemmanager Itemmanager;
    [SerializeField] private DynamicInventory ItemList;
    [SerializeField] private DynamicInventory Inventory;
    // Start is called before the first frame update
    void Start()
    {
      //  min = Itemmanager.test;
      //  if (min == 0) { Debug.Log("heyheyyayay"); }
      
    }


    


    void OnTriggerEnter2D(Collider2D collision)
    { 

        if(collision.GetComponent<Collider2D>().CompareTag("Crafter"))
        {
            int random = (int)Math.Floor((double)UnityEngine.Random.Range(0, ItemList.items.Count));

            if(used == false) {
                Debug.Log("Fuck maren");
                var Sword = ItemList.items[random];
                Inventory.AddDurability(Sword, Sword.durabulity);
                used = true;
                SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
                spriteRenderer.sprite = Sword.itemType.itemIcon;
            }
        }
    }
}
