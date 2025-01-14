using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class textReturn : MonoBehaviour
{
    public TMP_Text counter;
    public Blueprintcounter blueprint;
    public string number;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        number = blueprint.blueprintcounter.ToString();
        counter.SetText(number);
    }
}
