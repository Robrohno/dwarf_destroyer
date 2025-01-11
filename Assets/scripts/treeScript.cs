using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeScript : MonoBehaviour
{
    public Sprite[] trees;
    private SpriteRenderer spriterend;

    public void ActivateFoliage()
    {
        GetComponent<SpriteRenderer>().sprite = trees[Random.Range(0,trees.Length)];
    }
}
