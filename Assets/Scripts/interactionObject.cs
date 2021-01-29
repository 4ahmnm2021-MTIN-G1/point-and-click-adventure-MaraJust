using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactionObject : MonoBehaviour
{
    private inv inventory;
    public GameObject item;


    //public Vector3 scale;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<inv>();
    }

    public void PickUp ()
    {
        for (int i = 0; i < inventory.slots.Length; i++)
        {
            if (inventory.isFull[i] == false)
            {
                // add item to inventory
                inventory.isFull[i] = true;
                Instantiate(item, inventory.slots[i].transform, false);


                UnityEngine.Debug.Log(inventory.slots[i].transform.GetChild(0).name);
                inventory.itemsInInventory.Add(inventory.slots[i].transform.GetChild(0).name);
                UnityEngine.Debug.Log(inventory.itemsInInventory.Count);

                item.GetComponent<SpriteRenderer>().sortingOrder = 10;
                break;
            }
        }
        
    }

}
