/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using UnityEngine.UI;

public class LETProgressBar_Left : MonoBehaviour
{
    public TextStyle textStyle = TextStyle.Percentage;
    public bool showZero;
    public Slider slider;
    public Text text;

    void Update()
    {
        if (textStyle == TextStyle.Percentage)
            text.text = "-" + slider.value + "/100";
        else
            text.text = "-" + slider.value;

        if (!showZero && slider.value == 0)
            text.text = "";
    }
}