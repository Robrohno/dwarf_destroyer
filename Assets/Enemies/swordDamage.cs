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

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Enemy"))
        {
            enemyHealth -= 5;
            Debug.Log(enemyHealth + "enemy");
        }
    }
}
