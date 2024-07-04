using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScript : MonoBehaviour
{
    public void ReloadScene()
    {
        string currSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currSceneName);
    }

    public void ExitToMenu(int numScene)
    {
        SceneManager.LoadScene(numScene);
    }
}
