using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Magier : MonoBehaviour
{
    public string stringText = "Das ist ein Besipieltext in einer Stringvariable";
    public int intNumber = 55;
    public float floatNumber = 0.5f;
    public bool booley = false;

    public Rigidbody rb;
    public Text text;
    
    // Start is called before the first frame update
    void Start()
    {
        intNumber += 1;
        booley = true;
        floatNumber -= floatNumber;
        stringText = "Der Wert der Variable wurde in der Startfunktion geändert.";

        rb.useGravity = false;
        rb.mass = 80;
        text.text = "Wilfred Gruber.";
        text.fontSize = 23;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
