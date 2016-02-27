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
    public Transform nickName;
    
    public Sprite specialImage;
    public Sprite newGameImage;
    public Sprite loadGameImage;
    public Sprite historyImage;
    public Sprite creditsImage;
    public Sprite nickNameImage;
    
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
       nickName = transform.Find("NickNames").transform;
       
       specialImage = Resources.Load<Sprite>("Textures/cn/signBoard_special"); 
       newGameImage = Resources.Load<Sprite>("Textures/cn/signBoard_newGame");
       loadGameImage = Resources.Load<Sprite>("Textures/cn/signBoard_loadGame");
       historyImage = Resources.Load<Sprite>("Textures/cn/signBoard_history");
       creditsImage = Resources.Load<Sprite>("Textures/cn/signBoard_credits");
       nickNameImage = Resources.Load<Sprite>("Textures/cn/signBoard_nickNames");
       
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
       nickNameButton = nickName.GetComponent<Button>();
       nickNameButton.onClick.AddListener(delegate {ButtonManager.Instance.SendMessage("OnnickNameButtonClick");});
        
	   buttonButtonPre = Resources.Load<GameObject>("Prefabs/ButtonBord");
       LoadBord("DOCTOR SNLAD", specialImage, special);
       LoadBord("BELLY", newGameImage, newGame);
       LoadBord("MR SLAVE", loadGameImage, loadGame);
       LoadBord("SHANE", historyImage, history);
       LoadBord("GORDON", creditsImage, credits);
       LoadBord("PIKMAL", nickNameImage, nickName);
	}
	
    void LoadBord(string roleName, Sprite sprite, Transform parent)
    {
        GameObject go = Instantiate(buttonButtonPre);
        go.transform.SetParent(parent);
        go.transform.localPosition = Vector3.zero;
        go.transform.localScale = Vector3.one;
        go.GetComponent<ButtonBordItem>().InitBordItem(roleName, sprite);
    }
    
    
}