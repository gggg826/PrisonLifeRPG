﻿/*****************************
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
        CharactorsController.Instance.SetRoleInfoPanel(this);
        
        animation = GetComponent<Animation>();
        closeButton = transform.Find("CloseButton").GetComponent<Button>();
        closeButton.onClick.AddListener(delegate { HidenPanel(); });

        headICON = transform.Find("HeadICON/ICON").GetComponent<Image>();
        name = transform.Find("Name").GetComponent<Text>();
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
        animation.Play("PaperUp");
    }

    void HidenPanel()
    {
        animation.Play("PaperDown");
    }

    void InitPanel(CharactorModel model)
    {
        name.text = model.roleName;
        headICON.overrideSprite = Resources.Load<Sprite>("Textures/Charactors/" + model.bodyModel.headICONName);
        print(headICON.sprite.name);
        print(model.bodyModel.headICONName);
        power.text = model.power.ToString();
        agility.text = model.agility.ToString();
        intelligence.text = model.intelligence.ToString();
        charisma.text = model.charisma.ToString();
        luck.text = model.luck.ToString();
        prisonDays.text = model.prisonDays.ToString();
        prisonGol.text = model.prisonGol;

        foreach (string item in model.skillList)
        {
            print(item);
        }

        if (model.traitICON == null)
            trait.gameObject.SetActive(false);
        else
            // traitICON.overrideSprite = Resources.Load<Sprite>();
            print(traitICON.sprite.name);
    }
}