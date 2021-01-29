using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractablePerson : MonoBehaviour
{
    public GameObject actionPersonPanel;
    public BoxCollider2D colliderBox;
    public UIManager uiManager;

    public bool activeOrNot = false;

    public Text dialogFensterPersonen;

    // stays
    public string inspectText;

    public string LookText;
    public string badTalkText;
    public string goodTalkText;

    public bool alreadySearched = false;
    public bool itemTaken = false;

    public GameObject itemUseButton;

    public Transform actionPanelPosition;

    public void OnMouseDown()
    {
        Debug.Log("onMouseDown wird aufgerufen!");

        actionPersonPanel.SetActive(true);
        actionPersonPanel.transform.position = actionPanelPosition.position;


        //uiManager.activeIO = this; //this object
    }
}
