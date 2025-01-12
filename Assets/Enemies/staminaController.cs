using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class staminaController : MonoBehaviour
{
    public GameObject sword;
    [SerializeField] private Statbar staminaBar;
    [SerializeField] public float exhaustion = 0.001f;
    public float regeneration;
    public float timer = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {




        if (Input.GetMouseButton(0) & staminaBar.current > 0)
        {
            sword.SetActive(true);
            staminaBar.Subtract(exhaustion);
        }
        else
        {
            if (staminaBar.current == 0)
            {
                sword.SetActive(false);
            }

            else
            {
                sword.SetActive(false);
                staminaBar.Add(regeneration);
            }
                
        }

        if (staminaBar.current == 0)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                staminaBar.Add(regeneration);
                timer = 2f;
            }
        }
    }
}
