using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movementscripttilandetendindenfor : MonoBehaviour
{
    public float Speed = 5;


    Rigidbody2D rb;
    Vector3 startPosition;
    // Start is called before the first frame update
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
    if (collision.gameObject.CompareTag("Door 2"))
        {
            SceneManager.LoadScene("Hus Inside");
        }

    if (collision.gameObject.CompareTag("Door 3"))
    {
            SceneManager.LoadScene("Mine Indgang");
    }


    if (collision.gameObject.CompareTag("Door 4"))
    {
            SceneManager.LoadScene("Hus Område");
    }

    if (collision.gameObject.CompareTag("Door 5"))
    {
            SceneManager.LoadScene("Mine");
    }







    }
}
