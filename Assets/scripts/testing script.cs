using UnityEngine;

public class testingscript : MonoBehaviour
{
    [Header("Bar testing")]
    [SerializeField] private Statbar HealthBar;
    [SerializeField] private Statbar StaminaBar;
    [SerializeField] private float damage = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            HealthBar.Subtract(damage);
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            HealthBar.Add(damage);
        }
        if(Input.GetKeyDown(KeyCode.T))
        {
            StaminaBar.Subtract(damage);
        }
        if(Input.GetKeyDown(KeyCode.Y))
        {
            StaminaBar.Add(damage);
        }
    }
}
