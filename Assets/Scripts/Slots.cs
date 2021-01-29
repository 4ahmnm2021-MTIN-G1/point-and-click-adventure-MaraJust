using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slots : MonoBehaviour
{
    private inv inventory;
    public int i;

    public InteractableObject IO;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<inv>();
    }

    private void Update()
    {
        if (transform.childCount <= 0)
        {
            inventory.isFull[i] = false;
        }
    }

    public void DropItem()
    {
        foreach (Transform child in transform)
        {
            // remove item from slot
            UnityEngine.Debug.Log("Child destroyed");
            GameObject.Destroy(child.gameObject);

            UnityEngine.Debug.Log(child.gameObject.name);

            // remove item from inventory list
            inventory.itemsInInventory.Remove(child.gameObject.name);        }
    }
}
