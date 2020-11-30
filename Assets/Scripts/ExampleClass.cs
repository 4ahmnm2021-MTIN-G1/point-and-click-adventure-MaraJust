using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleClass : MonoBehaviour
{
    public float exampleFloat;
    public int exampleInt;
    public bool exampleBool;
    public string exampleString;

    public HingeJoint hj;
    public SpriteRenderer sr;
    public AudioSource audioSource;
    public GameObject thisObject;
    
    // Start is called before the first frame update
    void Start()
    {
        hj.massScale = exampleFloat;
        sr.sortingOrder = exampleInt;
        thisObject.name = exampleString;
        audioSource.loop = exampleBool;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
