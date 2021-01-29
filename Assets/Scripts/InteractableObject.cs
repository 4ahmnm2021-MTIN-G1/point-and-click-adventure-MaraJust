using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableObject : MonoBehaviour
{
   public GameObject actionPanel;
   public PolygonCollider2D collider;
   public UIManager uiManager;

   public bool activeOrNot = false;
    public bool somethingToDo;

   public Text dialogFenster;

    // stays
   public string inspectText;

   public string LookText;
   public string SearchText;
   public string CollectText;

   public bool alreadySearched = false;
    public bool itemTaken = false;

    public bool canUseItem;

    public GameObject itemUseButton;
    public GameObject takeObject;

   public Transform actionPanelPosition;

    public void OnMouseDown()
    {
        Debug.Log("onMouseDown wird aufgerufen!");

        actionPanel.SetActive(true);
        if(canUseItem == true)
        {
            itemUseButton.SetActive(true);
            takeObject.SetActive(false);

        }else
        {
            itemUseButton.SetActive(false);
            takeObject.SetActive(true);
        }
        actionPanel.transform.position = actionPanelPosition.position;

        uiManager.activeIO = this; //this object
    }
}
