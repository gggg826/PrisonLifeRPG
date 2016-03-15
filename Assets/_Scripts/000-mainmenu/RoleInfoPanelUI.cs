/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using UnityEngine.UI;

public class RoleInfoPanelUI : MonoBehaviour
{
    private Animation anim;
    private CharactorModel model;
    private Button closeButton;
    private Button OKButton;
    private Image headICON;
    private Text roleName;
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
        CharactorsController.Instance.SetRoleInfoPanel(this);
        
        anim = GetComponent<Animation>();
        closeButton = transform.Find("CloseButton").GetComponent<Button>();
        closeButton.onClick.AddListener(delegate { HidenPanel(); });

        OKButton = transform.Find("OK").GetComponent<Button>();
        OKButton.onClick.AddListener(delegate { ButtonManager.Instance.SendMessage("BeginGame", model); });

        headICON = transform.Find("HeadICON/ICON").GetComponent<Image>();
        roleName = transform.Find("Name").GetComponent<Text>();
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
    public void ShowPanel(CharactorModel model)
    {
        InitPanel(model);
        anim.Play("PaperUp");
    }

    void HidenPanel()
    {
        anim.Play("PaperDown");
        
        foreach (Transform item in transform.GetComponentsInChildren<Transform>())
        {
            if (item.parent == skillList)
            {
                GameObject.Destroy(item.gameObject);
            }
            
        }
    }

    void InitPanel(CharactorModel _model)
    {
        model = _model;
        roleName.text = model.roleName;
        headICON.sprite = TexturesManager.CharactorsBundle.LoadAsset<Sprite>(model.bodyModel.headICONName);
        power.text = model.power.ToString();
        agility.text = model.agility.ToString();
        intelligence.text = model.intelligence.ToString();
        charisma.text = model.charisma.ToString();
        luck.text = model.luck.ToString();
        prisonDays.text = model.prisonDays.ToString();
        prisonGol.text = model.prisonGol;
        foreach (string item in model.skillList.Split(','))
        {
            print(item);
            SkillManager.Instance.ShowSkill(item, skillList);
        }

        if (model.traitICON == "")
            trait.gameObject.SetActive(false);
        else
        {
            trait.gameObject.SetActive(true);
            // traitICON.overrideSprite = Resources.Load<Sprite>();
            print(model.traitICON);
        }
            
    }
}