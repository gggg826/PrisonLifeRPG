/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour 
{
    public Button shareButton;
    public Button languageSeletButton;
    public TopBGUI topUI;
    public BottomBGUI bottomUI;
    public LanguagePanel languagePanel;

    static private UIController instance;

    static public UIController Instance
    {
        get
        {
            if (instance == null)
                instance = new UIController();
            return instance;
        }

        set
        {
            instance = value;
        }
    }

    public UIController()
    {
        instance = this;
    }

    void Start () 
    {
       languagePanel = transform.parent.Find("BG/LanguageSelectPanel").GetComponent<LanguagePanel>();
        
	   shareButton = transform.parent.Find("BG/ShareButton").GetComponent<Button>();
       shareButton.onClick.AddListener(ShareButtonClick);
       
       languageSeletButton = transform.parent.Find("BG/LanguageButton").GetComponent<Button>();
       languageSeletButton.onClick.AddListener(LanguageButtonClick);
       
       topUI = TopBGUI.Instance;
       bottomUI = BottomBGUI.Instance;
    }
    
    void ShareButtonClick()
    {
        print("AirDrop");
    }
	
    void LanguageButtonClick()
    {
        languagePanel.ShowPanel();
    }

    public void LanguageButtonIconShow(Sprite currentSprite)
    {
        languageSeletButton.GetComponent<Image>().sprite = currentSprite;
    }
}