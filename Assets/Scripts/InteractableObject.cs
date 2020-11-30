using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableObject : MonoBehaviour
{
   public GameObject actionPanel;
   public PolygonCollider2D collider;
   public UIManager uiManager;

   public SpriteRenderer sr;
   public Image img;

   public bool activeOrNot = false;

   public Text dialogFenster;
   public string inspectText;

   public string LookText;
   public string SearchText;
   public string CollectText;
   public string CommentText;

   public bool alreadySearched = false;

    public void OnMouseDown()
    {
        Debug.Log("onMouseDown wird aufgerufen!");

        actionPanel.SetActive(true);
        //actionPanel.SetActive(activeOrNot);
        actionPanel.transform.position = transform.position;

        uiManager.activeIO = this; //this object

        //dialogFenster.text = inspectText;
        //activeOrNot = !activeOrNot;
    }
}
