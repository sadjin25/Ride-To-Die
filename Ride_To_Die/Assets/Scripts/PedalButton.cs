using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PedalButton : MonoBehaviour
{
    static public void OnClick()
    {
        Score.AddSpeed(1);
    }


}
