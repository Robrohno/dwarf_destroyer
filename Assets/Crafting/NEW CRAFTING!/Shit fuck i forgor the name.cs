using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Blueprintmousethingy : MonoBehaviour

{
    
    public Rigidbody2D rb2;
    // Start is called before the first frame update
    void Start()
    {
        rb2 = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
   
    private void Update()
    {

        
        




            if (Input.GetKeyDown("space"))
            {
                SceneManager.LoadScene("Hus Inside");
            }

        

            







        if ( Input.GetMouseButton(0)) {
            
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            
            Vector3 dr = transform.position - mousePosition;

            rb2.velocity = dr.normalized*10;


        }
    }
    
}
