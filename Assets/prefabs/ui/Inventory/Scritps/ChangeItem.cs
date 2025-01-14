using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChangeItem : MonoBehaviour
{
    [SerializeField] private DynamicInventory inventory;
    [SerializeField] private Image UIinventorySprite;
    private int damage;
    [SerializeField] private TextMeshProUGUI durabilityText;
    [SerializeField] private TextMeshProUGUI damageText;
    [SerializeField] private CombatSword combatSword;
    // Start is called before the first frame update
    void Start()
    {
        var sword = inventory.items[inventory.lastItemIndex];
        damage = sword.Damage;
        combatSword.damage = damage;
        UIinventorySprite.sprite = sword.itemType.itemIcon;
        combatSword.GetComponent<SpriteRenderer>().sprite = sword.itemType.itemIcon;
        ChangeText();
        ChangeBoxCollider();
    }
    // change the durability and damage text
    public void ChangeText()
    {
        var sword = inventory.items[inventory.lastItemIndex];
        if (sword.durabulity < 0)
        {
            durabilityText.text = "♾️";
        }
        else
        {
            durabilityText.text = sword.durabulity.ToString();
        }
        damageText.text = sword.Damage.ToString();
    }

    // changes the sword
    public void ChangeSword(int change)
    {
        if (inventory.items.Count > 0)
        {
            inventory.lastItemIndex += change;
            if (inventory.lastItemIndex < 0)
            {
                inventory.lastItemIndex = inventory.items.Count - 1;
            }
            else if (inventory.lastItemIndex >= inventory.items.Count)
            {
                inventory.lastItemIndex = 0;
            }
            var sword = inventory.items[inventory.lastItemIndex];
            damage = sword.Damage;
            combatSword.damage = damage;
            combatSword.GetComponent<SpriteRenderer>().sprite = sword.itemType.itemIcon;
            UIinventorySprite.sprite = sword.itemType.itemIcon;
            ChangeText();
            ChangeBoxCollider();
        }
    }

    private void ChangeBoxCollider()
    {
        var sword = inventory.items[inventory.lastItemIndex];
        combatSword.GetComponent<BoxCollider2D>().size = sword.itemType.itemIcon.bounds.size;
        combatSword.GetComponent<BoxCollider2D>().offset = sword.itemType.itemIcon.bounds.center;
    }

    // Update is called once per frame
    void Update()
    {
        // dont change too fast
        if (Time.timeScale != 0)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                ChangeSword(1);
            }
            else if (Input.GetKeyDown(KeyCode.Q))
            {
                ChangeSword(-1);
            }
        }
    }
}
