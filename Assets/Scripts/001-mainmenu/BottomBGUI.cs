/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using UnityEngine.UI;

public class BottomBGUI : MonoBehaviour 
{
    public BottomButtons bottomButtonPanel;
    public Text text;
    
    static private BottomBGUI instance;
    static public BottomBGUI Instance
    {
        get
        {
            if(instance == null) instance = new BottomBGUI();
            return instance;    
        }
        set
        {
            instance = value;
        }
    }
    
    public BottomBGUI()
    {
        instance = this;
    }
    
    void Awake()
    {
        bottomButtonPanel = transform.Find("BottomButtons").GetComponent<BottomButtons>();
        text = transform.Find("BottomText").GetComponent<Text>();
    }
}