using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class freeObjects : MonoBehaviour
{
    public Text DialogFenster;
    public string Comment;


    public void OnMouseDown()
    {
        DialogFenster.text = Comment;
    }
}
