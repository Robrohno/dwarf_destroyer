using UnityEngine;

public class Statbar : MonoBehaviour
{
    public RectTransform frontBar;
    public RectTransform backBar;
    public float max = 100;
    public float current = 100;
    public float decayRate = 0.1f;
    public float decaySpeed = 1;

    private float backBarCurrent = 0;

    void Start()
    {
        SetMax(max);
        SetCurrent(current);
    }

    public void SetCurrent(float value)
    {
        current = value;
        backBarCurrent = value;
        UpdateBar();
    }

    public void Add(float value)
    {
        current += value;
        if (current > max)
        {
            current = max;
        }
        if (backBarCurrent < current)
        {
            backBarCurrent = current;
            backBar.localScale = new Vector3(backBarCurrent / max, 1, 1);
        }
        UpdateBar();
    }

    public void Subtract(float value)
    {
        current -= value;
        if (current < 0)
        {
            current = 0;
        }
        UpdateBar();
    }

    public void SetMax(float value)
    {
        max = value;
        // Changes the width of the bar to match the new max value
        frontBar.sizeDelta = new Vector2(max, backBar.sizeDelta.y);
        backBar.sizeDelta = new Vector2(max, backBar.sizeDelta.y);
        UpdateBar();
    }

    private void UpdateBar()
    {
        frontBar.localScale = new Vector3(current / max, 1, 1);
    }

    private void AnimateBackBar()
    {
        // Smoothly animate the back bar to the current value
        var animateCalc = decayRate * Time.deltaTime * max;
        backBarCurrent -= animateCalc * decaySpeed;
        print(backBarCurrent);
        backBar.localScale = new Vector3(backBarCurrent / max, 1, 1);
    }

    void Update()
    {
        if (backBarCurrent > current)
        {
            AnimateBackBar();
        }
    }
}
