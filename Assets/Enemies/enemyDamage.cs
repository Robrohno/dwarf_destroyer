using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDamage : MonoBehaviour
{

    [SerializeField] private Statbar HealthBar;
    [SerializeField] private float damage = 1f;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
     
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            HealthBar.Subtract(damage);
        }
    }
}
