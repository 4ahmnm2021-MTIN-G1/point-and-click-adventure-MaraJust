using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManageScenes : MonoBehaviour
{
    public Canvas gameCanvas;

    public Camera[] myCams;

    public int scene;

    public Camera main;
    public Camera second;

    public Transform otherSceneCharacterTrans;
    public Transform thisSceneCharacterTrans;
    public GameObject MainCharacter;

    //public MainCharacterMovement;

    public GameObject MoveAreas;


    // Start is called before the first frame update
    void Start()
    {
       /* //Get Main Camera
        myCams[0] = GameObject.Find("Main Camera").GetComponent<Camera>();

        //Find All other Cameras
        myCams[1] = GameObject.Find("Second Camera").GetComponent<Camera>();*/
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeScene(int activatedCam)
    {
        if (activatedCam == 0)
        {
            main.enabled = true;
            second.enabled = false;
            // SetCharacterToOutside();
            gameCanvas.worldCamera = main;

        } else
        {
            second.enabled = true;
            main.enabled = false;
            //SetCharacterToCell();
            gameCanvas.worldCamera = second;
        }
        //Display.displays[sceneNumber].Activate();
        //
    }

    public void SetCharacterToCell()
    {
        MainCharacter.transform.position = otherSceneCharacterTrans.transform.position;
        MoveAreas.SetActive(true);
        MainCharacter.GetComponent<PlayerMovement>().enabled = false;
    }

    public void SetCharacterToOutside()
    {
        MainCharacter.transform.position = thisSceneCharacterTrans.transform.position;
        MoveAreas.SetActive(false);
        MainCharacter.GetComponent<PlayerMovement>().enabled = false;
    }
}