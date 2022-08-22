using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GearShiftBar : MonoBehaviour
{

    void Start()
    {
        maxGearShift = Score.GetMaxShift();
    }

    void Update()
    {
        UpdateShift();
        BarFiller();
        ColorChanger();

        lerpSpeed = 6f * Time.deltaTime;
    }

    void UpdateShift()
    {
        currentGearShift = Score.GetShift();    
    }

    void BarFiller()
    {
        Bar.fillAmount = Mathf.Lerp(Bar.fillAmount, (float)currentGearShift / maxGearShift, lerpSpeed);
    }

    void ColorChanger()
    {
        Color BarColor = Color.Lerp(Color.blue, Color.red, (float)currentGearShift / maxGearShift);

        Bar.color = BarColor;
    }

    public Image Bar;

    private float lerpSpeed;

    private float maxGearShift;
    private float currentGearShift;
}
