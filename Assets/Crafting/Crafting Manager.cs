using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftingManager : MonoBehaviour
{

    private Item currentItem;
    public Image customCursor;

    private void OnMouseDown()
    {
        

        if (currentItem == null)
        {
           // currentItem = item;
            customCursor.gameObject.SetActive(true);
            customCursor.sprite = currentItem.GetComponent<Image>().sprite;
        }
   }
}
