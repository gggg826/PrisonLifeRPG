/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfoUI1 : BasePlayerInfoSingleUI
{
    private Image headICON;
    private Text roleName;
    private Text power;
    private Text agility;
    private Text intelligence;
    private Text charisma;
    private Text luck;
    private Slider happiness;
    private Slider energy;
    private Slider healthy;
    private Slider fam;
    void Start ()
    {
        pageNO = 1;
        base.Init();
        base.ClickButtonEvent();


        headICON = transform.Find("HeadICON/ICON").GetComponent<Image>();
        roleName = transform.Find("Name").GetComponent<Text>();
        power = transform.Find("Image_Property/Text_Power").GetComponent<Text>();
        agility = transform.Find("Image_Property/Text_Agility").GetComponent<Text>();
        intelligence = transform.Find("Image_Property/Text_Intelligence").GetComponent<Text>();
        charisma = transform.Find("Image_Property/Text_Charisma").GetComponent<Text>();
        luck = transform.Find("Image_Property/Text_Luck").GetComponent<Text>();
        happiness = transform.Find("Image_happiness/Bar").GetComponent<Slider>();
        energy = transform.Find("Image_energy/Bar").GetComponent<Slider>();
        healthy = transform.Find("Image_healthy/Bar").GetComponent<Slider>();
        fam = transform.Find("Image_famours/Bar").GetComponent<Slider>();
    }

    public override void InitInfo()
    {
        headICON.sprite = TexturesManager.CharactorsBundle.LoadAsset<Sprite>(PlayerInfo.Instance.headIcon);
        roleName.text = PlayerInfo.Instance.playerName;
        power.text = PlayerInfo.Instance.power.ToString();
        agility.text = PlayerInfo.Instance.agility.ToString();
        intelligence.text = PlayerInfo.Instance.intelligence.ToString();
        charisma.text = PlayerInfo.Instance.charisma.ToString();
        luck.text = PlayerInfo.Instance.luck.ToString();
        happiness.value = PlayerInfo.Instance.happiness;
        energy.value = PlayerInfo.Instance.energy;
        healthy.value = PlayerInfo.Instance.healthy;
        fam.value = PlayerInfo.Instance.fame;
    }
}