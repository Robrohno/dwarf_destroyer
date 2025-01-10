using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDamage : MonoBehaviour
{
    public float playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        playerHealth = 100;
    }

    // Update is called once per frame
    void Update()
    {
     
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("CollisionDetected");
        if (collision.gameObject.CompareTag("Player"))
        {
            playerHealth -= 5;
           
        }
    }
}
