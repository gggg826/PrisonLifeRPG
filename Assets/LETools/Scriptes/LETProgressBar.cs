﻿/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using UnityEngine.UI;

public enum TextStyle
{
    ValueOnly,
    Percentage
}
public class LETProgressBar : MonoBehaviour
{
    public TextStyle textStyle = TextStyle.Percentage;
    public bool showZero;
    public Slider slider;
    public Text text;

    void Update()
    {
        if (textStyle == TextStyle.Percentage)
            text.text = slider.value + "/100";
        else
            text.text = slider.value.ToString();


        if (!showZero && slider.value == 0)
            text.text = "";
    }
}