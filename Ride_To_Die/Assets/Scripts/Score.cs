using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public void Update()
    {
        scoreText.text = PedalButton.GetScore().ToString(); 
    }

    [SerializeField]TextMeshProUGUI scoreText;
}
