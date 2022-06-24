using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public static int score = 0;
    public string scoreText = "Score";

    public Text textScore;
    public static ScoreUI gameScore;

    private void Awake()
    {
        gameScore = this;
    }
    
    void Update()
    {
        if(textScore != null)
        {
            textScore.text = scoreText + score.ToString();
        }
    }
}
