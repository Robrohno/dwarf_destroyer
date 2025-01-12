using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Statbar healthBar;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(healthBar.current == 0)
        {
            SceneManager.LoadScene(4);
        }
    }
}
