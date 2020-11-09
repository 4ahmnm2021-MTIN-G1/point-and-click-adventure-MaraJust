using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemActions : MonoBehaviour
{
    public GameObject actionPanel;
    public PolygonCollider2D collider;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start aufgerufen");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
       Debug.Log("onmousedown aufgerufen");
       actionAnimation();
    }

    public void actionAnimation () {

        actionPanel.SetActive(true);
    }

}
