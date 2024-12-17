using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float speed = 5;
    public int facingDirection = 1;

    public Rigidbody2D rb;
    public Animator anim;



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

        anim.SetFloat("horizontal", Mathf.Abs (horizontal));
        anim.SetFloat("vertical", vertical);
        if(vertical < 0)
        {
            anim.SetBool("walkingDown", true);
        }
        else
        {
            anim.SetBool("walkingDown", false);
        }

        if(horizontal != 0)
        {
            anim.SetBool("hoizontalWalking", true);
        }
        else
        {
            anim.SetBool("hoizontalWalking", false);
        }


        rb.velocity = new Vector2(horizontal, vertical) * speed;
    }


    void Flip()
    {
        facingDirection *= -1;
        transform.localScale = new Vector3 (transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }
}
