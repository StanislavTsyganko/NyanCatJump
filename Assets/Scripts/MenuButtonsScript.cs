using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonsScript : MonoBehaviour
{
    public void PlayScene(int numScene)
    {
        SceneManager.LoadScene(numScene);
    }

    public void RecordsScene(int numScene)
    {
        SceneManager.LoadScene(numScene);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
