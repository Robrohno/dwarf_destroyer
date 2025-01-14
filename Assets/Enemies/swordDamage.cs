using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordDamage : MonoBehaviour
{
    public float enemyHealth;
    [SerializeField] private EnemyHealthBar HealthBar;
    public Blueprintcounter blueprints;
    public int min = 0;
    public int max = 2;
    void Start()
    {
        enemyHealth = 100;
        HealthBar.enemyHealth = enemyHealth;
        HealthBar.max = enemyHealth;
        HealthBar.backBarCurrent = enemyHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHealth <= 0)
        {
            Destroy(gameObject);
            
            if(Random.Range(min,max) == 1)  blueprints.blueprintcounter += 1; 
            
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collison");
        if (collision.gameObject.CompareTag("Sword"))
        {
            enemyHealth -= collision.gameObject.GetComponent<CombatSword>().damage;
            HealthBar.SetHealth(enemyHealth);
            Debug.Log(enemyHealth + "enemy");
            collision.gameObject.GetComponent<CombatSword>().DecreaseDurability();
        }
    }
}
