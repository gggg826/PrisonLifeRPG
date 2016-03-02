/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using UnityEngine.UI;

public class RoleInfoPanelUI : MonoBehaviour
{
    private Animation animation;
    private Button closeButton;
    private Image headICON;
    private Text name;
    private Text power;
    private Text agility;
    private Text intelligence;
    private Text charisma;
    private Text luck;
    private Text prisonDays;
    private Text prisonGol;
    private Transform skillList;
    private Transform trait;
    private Image traitICON;

    void Start()
    {
        animation = GetComponent<Animation>();
        closeButton = transform.Find("CloseButton").GetComponent<Button>();
        closeButton.onClick.AddListener(delegate { HidenPanel(); });
        
        headICON = transform.Find("HeadICON").GetComponent<Image>();
        name =transform.Find("Name").GetComponent<Text>();
        power = transform.Find("Image_Property/Text_Power").GetComponent<Text>();
        agility = transform.Find("Image_Property/Text_Agility").GetComponent<Text>();
        intelligence = transform.Find("Image_Property/Text_Intelligence").GetComponent<Text>();
        charisma = transform.Find("Image_Property/Text_Charisma").GetComponent<Text>();
        luck = transform.Find("Image_Property/Text_Luck").GetComponent<Text>();
        prisonDays = transform.Find("Days/Text").GetComponent<Text>();
        prisonGol = transform.Find("PersonalGol/Text").GetComponent<Text>();
        skillList = transform.Find("Skill/SkillList").transform;
        trait = transform.Find("Trait").transform;
        traitICON = trait.Find("Image/Image").GetComponent<Image>();
        
    }
    public void ShowPanel()
    {
        
        animation.Play("PaperUp");
    }

    void HidenPanel()
    {
        animation.Play("PaperDown");
    }
    
    void InitPanel()
    {
        
    }
}