using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject PausenMenu;
   
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PausenMenu.SetActive(true);
        }
    }

    public void PlayButton()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void StopGame()
    {
        SceneManager.LoadScene("Menu");
    }
}

