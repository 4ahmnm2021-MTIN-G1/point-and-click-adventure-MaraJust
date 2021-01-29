using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UseItems : MonoBehaviour
{
    public inv inventory;
    public interactionObject interactionO;
    public Slots slots;

    public Text UseItemsText;
    
    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<inv>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void UseTheItems(string neededObject)
    {
        if(inventory.itemsInInventory.Contains(neededObject + "(clone)"))
        {
            UnityEngine.Debug.Log("it contains it");
            //slots.DropItem();
        }
    }

    
}
