/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using UnityEngine.UI;

public class BottomButtons : MonoBehaviour 
{
    
    public Button reviewsButton;
    public Button gamecentreButton;
    public Button facebookshareButton;
    public Button twittershareButton;
    public Button emailButton;
    
    static private BottomButtons instance;
    static public BottomButtons Instance
    {
        get
        {
            if(instance == null) instance = new BottomButtons();
            return instance;
        }
        set
        {
     
               instance = value;
        }
    }
    
    public BottomButtons()
    {
        instance = this;
    }

	void Start () 
    {
	   reviewsButton = transform.Find("ReviewsButton").GetComponent<Button>();
       reviewsButton.onClick.AddListener(ReviewsButtonClick);
       
       gamecentreButton = transform.Find("GameCentreButton").GetComponent<Button>();
       gamecentreButton.onClick.AddListener(GameCentreButtonClick);
       
       facebookshareButton = transform.Find("FacebookButton").GetComponent<Button>();
       facebookshareButton.onClick.AddListener(FacebookButtonClick);
       
       twittershareButton = transform.Find("TwitterButton").GetComponent<Button>();
       twittershareButton.onClick.AddListener(TwitterShareButtonClick);
       
       emailButton =transform.Find("EmailButton").GetComponent<Button>();
       emailButton.onClick.AddListener(EmailButtonClick);
	}
    
    void ReviewsButtonClick()
    {
        print("请评价 -- 调用App Store");
    }
    
        void GameCentreButtonClick()
    {
        print("打开游戏控制中心 -- 调用Game Centre");
    }
    
        void FacebookButtonClick()
    {
        print("分享到FACEBOOK");
    }
    
        void TwitterShareButtonClick()
    {
        print("分享到TWITTER");
    }
    
        void EmailButtonClick()
    {
        print("给我发电邮 -- 调用Email");
    }
}