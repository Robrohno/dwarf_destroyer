using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.UI;

public class testingscript : MonoBehaviour
{
    [Header("Bar testing")]
    [SerializeField] private Statbar HealthBar;
    [SerializeField] private Statbar StaminaBar;
    [SerializeField] private float damage = 0.1f;


    [SerializeField] private DynamicInventory inventory;
    [SerializeField] private UnityEngine.UI.Image UiInventory;
    [SerializeField] private int InventoryId;
    // Start is called before the first frame update
    void Start()
    {
        UiInventory.sprite = inventory.items[InventoryId].itemType.itemIcon;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            HealthBar.Subtract(damage);
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            HealthBar.Add(damage);
        }
        if(Input.GetKeyDown(KeyCode.T))
        {
            StaminaBar.Subtract(damage);
        }
        if(Input.GetKeyDown(KeyCode.Y))
        {
            StaminaBar.Add(damage);
        }
        if(Input.GetKeyDown(KeyCode.RightArrow)) {
            InventoryId++;
            if(InventoryId >= inventory.items.Count)
            {
                InventoryId = 0;
            }
            UiInventory.sprite = inventory.items[InventoryId].itemType.itemIcon;
            Debug.Log(inventory.items[InventoryId].Damage);
        }
    }
}
