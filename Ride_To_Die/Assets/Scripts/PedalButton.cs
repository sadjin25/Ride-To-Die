using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PedalButton : MonoBehaviour
{
    static public void OnClick()
    {
        score++;
        Debug.Log("1");
    }

    static public int GetScore()
    {
        return score; 
    }
    
    static private int score;
}
