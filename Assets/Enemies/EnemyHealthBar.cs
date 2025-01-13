using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthBar : MonoBehaviour
{
    [SerializeField] private Transform Front;
    [SerializeField] private Transform Back;
    public float enemyHealth;
    public float max;
    private bool hidden = true;
    public float decayRate = 0.1f;
    public float decaySpeed = 1;
    public float backBarCurrent = 0;

    void Start ()
    {
        gameObject.SetActive(false);
    }

    public void SetHealth(float health)
    {
        if (hidden) gameObject.SetActive(true);
        hidden = false;
        enemyHealth = health;
        Front.localScale = new Vector3(enemyHealth / 100, Front.localScale.y, Front.localScale.z);
    }

    private void AnimateBackBar()
    {
        // Smoothly animate the back bar to the current value
        var animateCalc = decayRate * Time.deltaTime * max;
        backBarCurrent -= animateCalc * decaySpeed;
        Back.localScale = new Vector3(backBarCurrent / max, Back.localScale.y, Back.localScale.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (backBarCurrent > enemyHealth)
        {
            AnimateBackBar();
        }
    }
}
