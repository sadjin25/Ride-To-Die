using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PedalButton : MonoBehaviour
{
    static public void OnClick()
    {
        Score.AddScore(500);
        Debug.Log("1");
    }


}
