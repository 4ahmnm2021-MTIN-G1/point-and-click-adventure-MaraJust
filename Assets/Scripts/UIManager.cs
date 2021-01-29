using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public InteractableObject activeIO;
    public InteractablePerson activeIP;
    public Text talkFenster;
    public Text dialogFenster;
    public Text commentFenster;

    public void DisplayText () 
    {
        Debug.Log("DisplayText wird aufgerufen");
        dialogFenster.text = activeIO.inspectText;
        talkFenster.text = activeIP.inspectText;
    }

    public void Exit () 
    {
        dialogFenster.text = " ";
    }

    public void CollectItem ()
    {
        if (activeIO.alreadySearched == true && activeIO.itemTaken == false)
        {
            Debug.Log("CollectItem Function ist aufgerufen");

            dialogFenster.text = activeIO.CollectText;
            activeIO.GetComponent<interactionObject>().PickUp();
            activeIO.itemTaken = true;

        } else 
        {
            dialogFenster.text = "Nichts tragbares mehr gefunden.";
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

    public void TalkEvil()
    {
        talkFenster.text = activeIP.badTalkText;
    }
    public void TalkGood()
    {
        talkFenster.text = activeIP.goodTalkText;
    }
    public void LookAtHim()
    {
        talkFenster.text = activeIP.LookText;
    }
}
