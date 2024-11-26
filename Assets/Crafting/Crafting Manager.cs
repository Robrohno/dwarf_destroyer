using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftingManager : MonoBehaviour
{

    private Item SelectedObject;
    public Image customCursor;

    public Slot[] craftingSlots;


    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            
            if (SelectedObject != null)
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
                nearestSlot.GetComponent<Image>().sprite = SelectedObject.GetComponent<Image>().sprite;
                nearestSlot.item = SelectedObject;
                SelectedObject = null;
            }

        }

    }


    private void OnMouseDown(){
       




        if (SelectedObject == null)
        {
           // currentItem = item;
            customCursor.gameObject.SetActive(true);
            customCursor.sprite = SelectedObject.GetComponent<Image>().sprite;
        }
   }
}
