using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Player : MonoBehaviour
{
<<<<<<< HEAD:Assets/inside house/player house.cs
    [SerializeField] private Blueprintcounter blueprint;
    float Speed = 5;
=======
    //static int nextScene = 0;
    int score;
    public float Speed = 5;

>>>>>>> bff2007d4a2e900c18d3056f79f3289793e9432f:Assets/player house.cs
    Rigidbody2D rb;
    Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(0, 0, 0);
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");
        direction = Vector3.ClampMagnitude(direction, 1);
        direction *= Speed;
        rb.velocity = direction;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("door"))
        {
            SceneManager.LoadScene("dungeon test");


        }




        if (collision.gameObject.CompareTag("player") && blueprint.blueprintcounter >= 1)
        {
            blueprint.blueprintcounter = blueprint.blueprintcounter - 1;
            SceneManager.LoadScene("NEW CRAFTING! I HATE CRAFTING!");
        }

    }
    
}
