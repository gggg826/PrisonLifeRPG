/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using UnityEngine.UI;

public class BottomPanelUI : MonoBehaviour 
{
    public BottomButtons bottomButtonPanel;
    public Text text;
    
    void Start()
    {
        bottomButtonPanel = transform.Find("BottomButtons").GetComponent<BottomButtons>();
        text = transform.Find("BottomText").GetComponent<Text>();
    }
}