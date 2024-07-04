using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreControlScript : MonoBehaviour
{
    public void IncreaseScore()
    {
        ScoreScript.score += 1;
    }
}
