using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItemsOn : MonoBehaviour
{

    public GameObject objectNeeded;
    private string objecty;

    public UseItems Ui;

    // Start is called before the first frame update
    void Start()
    {
        objectNeeded.name = objecty;
        UnityEngine.Debug.Log(objecty);
    }

    public void CheckIfItemIsThere()
    {
        Ui.UseTheItems(objecty);
    }
}
