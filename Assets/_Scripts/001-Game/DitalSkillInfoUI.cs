/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using UnityEngine.UI;

public class DitalSkillInfoUI : MonoBehaviour 
{
    private Image skillIcon;
    private Text des;
    private Button close;
    private Animation anim;
	void Start () 
    {
	    skillIcon = transform.Find("Icon/Image").GetComponent<Image>();
        des = transform.Find("Text").GetComponent<Text>();
        close = transform.Find("Panel").GetComponent<Button>();
        anim = GetComponent<Animation>();
	}
    
    public void Init(SkillModel model)
    {
        skillIcon.sprite = TexturesManager.IconBundle.LoadAsset<Sprite>(model.spriteIcon);
        des.text = model.des;
        close.onClick.AddListener(delegate { HidePanel();});
    }
    
    void HidePanel()
    {
        anim.Play("PaperDown");
    }
    
    public void ShowPanel()
    {
        anim.Play("PaperUp");
    }
}