/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using UnityEngine.UI;

public class LETProgressBar : MonoBehaviour 
{
    public Slider slider;
    public Text text;
    
	public void ShowPrecent() 
    {
	    text.text = slider.value + "/100";
	}
}