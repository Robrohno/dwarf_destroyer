using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantScript : MonoBehaviour
{
    public Sprite[] plants;
    private SpriteRenderer spriterend;

    public void ActivateFoliage()
    {
        GetComponent<SpriteRenderer>().sprite = plants[Random.Range(0,plants.Length)];
    }
}

