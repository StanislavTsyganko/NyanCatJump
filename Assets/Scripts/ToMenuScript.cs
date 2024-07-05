using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ToMenuScript : MonoBehaviour
{

    public void ExitToMenu(int numScene)
    {
        SceneManager.LoadScene(numScene);
    }
}
