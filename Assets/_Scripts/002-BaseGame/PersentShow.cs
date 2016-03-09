/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using UnityEngine.UI;

public class PersentShow : MonoBehaviour 
{
    public Slider slider;
    public Text text;
    
	void Update () 
    {
	    text.text = slider.value + "/100";
	}
}