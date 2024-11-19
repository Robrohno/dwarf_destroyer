using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class Selector : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
   
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log(this.gameObject.name + " Was Clicked.");

        CustomCursor.SelectedObject = gameObject;


    }
    public void OnPointerUp(PointerEventData eventData)
    {

        CustomCursor.SelectedObject = null;


    }


}