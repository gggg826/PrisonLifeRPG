/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using UnityEngine.UI;

public class TopBGUI : MonoBehaviour 
{
    public Text titleText1;
    public Text titleText2;
    public Text titleText3;
    public Text titleText4;
  
    static private TopBGUI instance;
    static public TopBGUI Instance
    {
        get
        {
            if(instance == null) instance = new TopBGUI();
            return instance;   
        }
        set
        {
            instance = value;
        }
    }
    
    public TopBGUI()
    {
        instance = this;
    }
    
	void Start () 
    {
	   titleText1 = transform.Find("TitleText1").GetComponent<Text>();
	   titleText2 = transform.Find("TitleText2").GetComponent<Text>();
	   titleText3 = transform.Find("TitleText3").GetComponent<Text>();
	   titleText4 = transform.Find("TitleText4").GetComponent<Text>();
	}
	
    public void SetTopBGUI(string str1, string str2, string str3, string str4)
    {
        titleText1.text = str1;
        titleText2.text = str2;
        titleText3.text = str3;
        titleText4.text = str4;
    }
}