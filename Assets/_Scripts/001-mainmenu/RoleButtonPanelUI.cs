/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using UnityEngine.UI;

public class RoleButtonPanelUI : MonoBehaviour 
{
    public Transform special;
    public Transform newGame;
    public Transform loadGame;
    public Transform history;
    public Transform credits;
    public Transform achievements;
    
    public Sprite specialImage;
    public Sprite newGameImage;
    public Sprite loadGameImage;
    public Sprite historyImage;
    public Sprite creditsImage;
    public Sprite achievementsImage;
    
    public Button specialButton;
    public Button newGameButton;
    public Button loadGameButton;
    public Button historyButton;
    public Button creditsButton;
    public Button nickNameButton;
    
    GameObject buttonButtonPre;
	void Start () 
    {
       special = transform.Find("Special").transform;
       newGame = transform.Find("NewGame").transform;
       loadGame = transform.Find("LoadGame").transform;
       history = transform.Find("History").transform;
       credits = transform.Find("Credits").transform;
       achievements = transform.Find("Achievements").transform;
       
       specialImage = Resources.Load<Sprite>("Textures/cn/signBoard_special"); 
       newGameImage = Resources.Load<Sprite>("Textures/cn/signBoard_newGame");
       loadGameImage = Resources.Load<Sprite>("Textures/cn/signBoard_loadGame");
       historyImage = Resources.Load<Sprite>("Textures/cn/signBoard_history");
       creditsImage = Resources.Load<Sprite>("Textures/cn/signBoard_credits");
       achievementsImage = Resources.Load<Sprite>("Textures/cn/signBoard_nickNames");
       
       specialButton = special.GetComponent<Button>();
       specialButton.onClick.AddListener(delegate {ButtonManager.Instance.SendMessage("OnspecialButtonClick");});
       newGameButton = newGame.GetComponent<Button>();
       newGameButton.onClick.AddListener(delegate {ButtonManager.Instance.SendMessage("OnnewGameButtonClick");});
       loadGameButton = loadGame.GetComponent<Button>();
       loadGameButton.onClick.AddListener(delegate {ButtonManager.Instance.SendMessage("OnloadGameButtonClick");});
       historyButton = history.GetComponent<Button>();
       historyButton.onClick.AddListener(delegate {ButtonManager.Instance.SendMessage("OnhistoryButtonClick");});
       creditsButton = credits.GetComponent<Button>();
       creditsButton.onClick.AddListener(delegate {ButtonManager.Instance.SendMessage("OncreditsButtonClick");});
       nickNameButton = achievements.GetComponent<Button>();
       nickNameButton.onClick.AddListener(delegate {ButtonManager.Instance.SendMessage("OnnickNameButtonClick");});
        
        LoadBord("DOCTOR SNLAD", ROLESTATUS.Normal, specialImage, special);
        LoadBord("BELLY", ROLESTATUS.Normal, newGameImage, newGame);
        LoadBord("MR SLAVE", ROLESTATUS.Normal, loadGameImage, loadGame);
        LoadBord("SHANE", ROLESTATUS.Normal, historyImage, history);
        LoadBord("GORDON", ROLESTATUS.Normal, creditsImage, credits);
        LoadBord("PIKMAL", ROLESTATUS.Normal, achievementsImage, achievements);
    }
	
    void LoadBord(string roleName, ROLESTATUS status, Sprite sprite, Transform parent)
    {
        CharactorsController.Instance.AddButtonBordToScreen(roleName, status, sprite, parent);
    }
    
    
}