using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftingManager : MonoBehaviour
{

    private Item currentitem;
    public Image customCursor;

    public Slot[] craftingSlots;

    

    


    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            
            if (currentitem != null)
            {
                Debug.Log(" hey");
                customCursor.gameObject.SetActive(false);
                Slot nearestSlot = null;
                float shortestDistance = float.MaxValue;

                foreach (Slot slot in craftingSlots)
                {
                    float dist = Vector2.Distance(Input.mousePosition, slot.transform.position);
                    if (dist < shortestDistance)
                    {
                        shortestDistance = dist;
                        nearestSlot = slot;
                    }

                }
                nearestSlot.gameObject.SetActive(true);
                nearestSlot.GetComponent<Image>().sprite = currentitem.GetComponent<Image>().sprite;
                nearestSlot.item = currentitem;
                currentitem = null;
            }

        }

    }


    public void OnMouseDown(){
       




        if (currentitem == null)
        {
           //currentItem = item;
            customCursor.gameObject.SetActive(true);
            customCursor.sprite = currentitem.GetComponent<Image>().sprite;
        }
   }
}
