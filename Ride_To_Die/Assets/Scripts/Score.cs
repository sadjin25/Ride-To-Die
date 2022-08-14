using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public void Update()
    {
        scoreText.text = score.ToString();
        AddScore(scorePerFrame);
    }

    static public int GetScore()
    {
        return score;
    }

    static public void AddScore(int score_)
    {
        score += score_;
    }

    [SerializeField] TextMeshProUGUI scoreText;
    static private int score;
    static private int scorePerFrame = 1;
}
