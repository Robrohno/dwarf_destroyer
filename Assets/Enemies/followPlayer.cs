using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public float radius;
    private float distance;
    [SerializeField] private Statbar HealthBar;
    [SerializeField] private float damage = 0.1f;
    public float Timer = 2f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        distance = Vector2.Distance(transform.position, player.transform.position);
        if (distance < radius & distance > 3)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
        }
        if (distance <= 3)
        {
            Timer -= Time.deltaTime;
            if (Timer <= 0)
            {
                HealthBar.Subtract(damage);
                Timer = 2f;
            }

        }
    }
}
