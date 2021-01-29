using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public ManageScenes MS;
    public int numberOfScene;

    private void OnMouseDown()
    {
        MS.ChangeScene(numberOfScene);
    }
}
