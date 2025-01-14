using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Player : MonoBehaviour
{

    [SerializeField] private Blueprintcounter blueprint;


    int score;
    public float speed = 5;
    private int facingDirection = 1;
    private float deadzone = 0.1f;

    public Rigidbody2D rb;
    public Animator anim;

    Vector3 startPosition;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

   // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        if(horizontal > 0 && transform.localScale.x < 0 ||
             horizontal < 0 && transform.localScale.x > 0)
        {
            Flip();
        }

        /*         anim.SetFloat("horizontal", Mathf.Abs (horizontal));
        anim.SetFloat("vertical", vertical); */
        
        if(vertical > deadzone && Mathf.Abs (vertical) >= Mathf.Abs (horizontal)){
            anim.SetBool("walkingUp", true);
        }
        else{
            anim.SetBool("walkingUp", false);
        }
        if(vertical < 0f-deadzone && Mathf.Abs (vertical) >= Mathf.Abs (horizontal)){
            anim.SetBool("walkingDown", true);
        }
        else{
            anim.SetBool("walkingDown", false);
        }
        
        if(Mathf.Abs (horizontal) > deadzone && Mathf.Abs (horizontal) > Mathf.Abs (vertical)){
            anim.SetBool("walking", true);
        }
        else{
            anim.SetBool("walking", false);
        }
        rb.velocity = new Vector2(horizontal, vertical).normalized * speed;

        void Flip()
        {
            facingDirection *= -1;
            transform.localScale = new Vector3 (transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("door"))
        {
            SceneManager.LoadScene("Hus Omrade");

        }


        {



            if (collision.gameObject.CompareTag("player") && blueprint.blueprintcounter >= 1)
            {
                blueprint.blueprintcounter = blueprint.blueprintcounter - 1;
                SceneManager.LoadScene("NEW CRAFTING! I HATE CRAFTING!");
            }

        }

    }
}
