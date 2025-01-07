using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class Inputslot : MonoBehaviour
{
    public Durability sworddurability;
    bool used = false;
    float max=100;
    float min=1;
   [SerializeField] private SwordCounter counter;

    public Sprite Sword;
    [SerializeField] private Itemmanager Itemmanager;
    public Sprite Bettersword;
    public Sprite bloodsword;
    public Sprite draculasword;
    public Sprite bananasword;
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
                sworddurability.sword1durability = sworddurability.sword1durability + 40;
            used = true;

            
            Debug.Log("YEAH!!!");

            }
            if (random >= 21 && random <= 40 && used == false) 
            {
                SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
                spriteRenderer.sprite = Bettersword;
                used = true;
                counter.swordTwoCount += 1;
                sworddurability.sword2durability = sworddurability.sword2durability + 60;
            }
            if (random >= 41 && random <= 60 && used == false)
            {
                SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
                spriteRenderer.sprite = bloodsword;
                used = true;
                counter.swordThreeCount += 1;
                sworddurability.sword3durability = sworddurability.sword3durability + 80;
            }
            if (random >= 61 && random <= 80 && used == false)
            {
                SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
                spriteRenderer.sprite = draculasword;
                used = true;
                counter.swordFourCount += 1;
                sworddurability.sword4durability = sworddurability.sword4durability + 100;
            }
            if (random >= 81 && random <= 100 && used == false)
            {
                SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
                spriteRenderer.sprite = bananasword;
                used = true;
                counter.swordFiveCount += 1;
                sworddurability.sword5durability = sworddurability.sword5durability + 120;
            }
        }
    }
}
