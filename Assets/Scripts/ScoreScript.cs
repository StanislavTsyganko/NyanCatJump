using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreScript : MonoBehaviour
{

    [SerializeField] Text HighscoreText;
    [SerializeField] Text ScoreText;
    [SerializeField] Text currScoreText;
    public static float score = 0;
    int highscore = 0;

    void Start()
    {
        score = 0;
    }

    private void Update()
    {
        highscore = (int)score;
        ScoreText.text = "" + highscore.ToString();
        //currScoreText.text = "" + highscore.ToString();
        if (PlayerPrefs.GetInt("score") <= highscore)
            PlayerPrefs.SetInt("score", highscore); //highscore = score;
        HighscoreText.text = PlayerPrefs.GetInt("score").ToString();
    }
}
