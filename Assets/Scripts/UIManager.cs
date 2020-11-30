using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public InteractableObject activeIO;
    public Text dialogFenster;
    public Text commentFenster;

    public void DisplayText () 
    {
        Debug.Log("DisplayText wird aufgerufen");
        dialogFenster.text = activeIO.inspectText;
    }

    public void Exit () 
    {
        dialogFenster.text = " ";
    }

    public void CollectItem ()
    {
        if (activeIO.alreadySearched = true)
        {
            Debug.Log("CollectItem Function ist aufgerufen");

            dialogFenster.text = activeIO.CollectText;
            activeIO.img.sprite = activeIO.sr.sprite;
        } else 
        {
            dialogFenster.text = "Bis jetzt nichts tragbares gefunden.";
        }
    }

    public void Search () 
    {
        dialogFenster.text = activeIO.SearchText;
        activeIO.alreadySearched = true;
    }

    public void TakeALook () 
    {
        dialogFenster.text = activeIO.LookText;
    }
}
