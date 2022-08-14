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
    }

    static public int GetScore()
    {
        return score;
    }

    static public void AddScore()
    {
        score++;
    }

    [SerializeField]TextMeshProUGUI scoreText;
    static private int score;
}
