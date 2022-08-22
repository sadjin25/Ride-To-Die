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
    }

    void UpdateShift()
    {
        currentGearShift = Score.GetShift();    
    }

    void BarFiller()
    {
        Bar.fillAmount = (float)currentGearShift / maxGearShift;
    }

    public Image Bar;
    private float maxGearShift;
    private float currentGearShift;
}
