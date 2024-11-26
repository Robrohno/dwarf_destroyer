using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class CustomCursor : MonoBehaviour
{
    public static GameObject SelectedObject;
    private void Update()
    {
        if (SelectedObject != null)
        {
            SelectedObject.transform.position = Input.mousePosition;
        }
        

    }
   
    
}
