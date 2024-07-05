using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LoseScript : MonoBehaviour
{
    [SerializeField] Text currScore;
    [SerializeField] RecordsScript records;

    public void ReloadScene()
    {
        string currSceneName = SceneManager.GetActiveScene().name;
        int record = 0;
        int.TryParse(currScore.text, out record);
        records.AddRecord(record);
        SceneManager.LoadScene(currSceneName);
    }

    public void ExitToMenu(int numScene)
    {
        int record = 0;
        int.TryParse(currScore.text, out record);
        records.AddRecord(record);
        SceneManager.LoadScene(numScene);
    }
}
