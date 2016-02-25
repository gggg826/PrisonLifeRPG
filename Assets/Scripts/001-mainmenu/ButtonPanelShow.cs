/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using UnityEngine.UI;

public class ButtonPanelShow : MonoBehaviour 
{
    public Transform special;
    public Transform newGame;
    public Transform loadGame;
    public Transform history;
    public Transform cridits;
    public Transform nickName;
    
    public Sprite specialImage;
    public Sprite newGameImage;
    public Sprite loadGameImage;
    public Sprite historyImage;
    public Sprite criditsImage;
    public Sprite nickNameImage;
    
    GameObject buttonButtonPre;
	void Start () 
    {
	   buttonButtonPre = Resources.Load<GameObject>("Prefabs/ButtonBord");
       LoadBord("DOCTOR SNLAD", specialImage, special);
       LoadBord("BELLY", newGameImage, newGame);
       LoadBord("MR SLAVE", loadGameImage, loadGame);
       LoadBord("SHANE", historyImage, history);
       LoadBord("GORDON", criditsImage, cridits);
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