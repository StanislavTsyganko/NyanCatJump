using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreControlScript : MonoBehaviour
{

    public void IncreaseScore()
    {
        ScoreScript.score += 1;
    }
}
