using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Inputslot : MonoBehaviour
{
    float max=100;
    float min=1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ;
        if(Random.Range(min, max)<=20)  
        {
            Debug.Log("YEAH!!!");
        }
    }
}
