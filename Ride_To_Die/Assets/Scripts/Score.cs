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
        AddScore(gearShift);
        Debug.Log(gearShift);
    }

    static public int GetScore()
    {
        return score;
    }
    static public int GetMaxShift()
    {
        return maxGearShift;
    }
    static public int GetShift()
    {
        return gearShift;
    }

    static public void AddSpeed(int score_)
    {
        gearShift += score_;
        if(gearShift > maxGearShift) gearShift = 5;    
    }

    static public void AddScore(int score_)
    {
        score += score_;

        scoreFrameTime++;
        if (scoreFrameTime >= 50)
        {
            scoreFrameTime = 0;
            gearShift--;

            if (gearShift <= 0) gearShift = 1;
        }
    }

    [SerializeField] TextMeshProUGUI scoreText;
    static private int score;
    static private int gearShift = 1;
    static private int scoreFrameTime = 0;

    // To-Do : make different max gear shift as player's gear changed.
    const int maxGearShift = 11;   

}
