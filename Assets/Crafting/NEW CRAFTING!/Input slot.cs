using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class Inputslot : MonoBehaviour
{
    
    bool used = false;
    float max=100;
    float min=1;
   [SerializeField] private SwordCounter counter;

    public Sprite Sword;
    [SerializeField] private Itemmanager Itemmanager;
    public Sprite Bettersword;
    // Start is called before the first frame update
    void Start()
    {
      //  min = Itemmanager.test;
      //  if (min == 0) { Debug.Log("heyheyyayay"); }
      
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Crafter"))
        {
            float random = Random.Range(min, max);
            if (random<=20 && used == false)  
             {
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = Sword;
                counter.swordOneCount += 1;
            used = true;
            
            Debug.Log("YEAH!!!");

            }
            if (random >= 21 && random <= 40 && used == false) 
            {
                SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
                spriteRenderer.sprite = Bettersword;
                used = true;
                counter.swordTwoCount += 1;
            }
        }
    }
}
