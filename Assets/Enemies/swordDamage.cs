using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordDamage : MonoBehaviour
{
    public float enemyHealth;
    void Start()
    {
        enemyHealth = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collison");
        if (collision.gameObject.CompareTag("Sword"))
        {
            enemyHealth -= 5;
            Debug.Log(enemyHealth + "enemy");


        }
    }
}
