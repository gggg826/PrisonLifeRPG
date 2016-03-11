/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using UnityEngine.UI;

public class TopInfoShowPanelUI : MonoBehaviour
{

    private Slider slider_happiness;
    private Slider slider_energy;
    private Slider slider_heathy;
    private Image partyPosition;
    private Text time;
    private Text money;
    private Text daysLeft;
    private Button menu;
    public Button showInfoPanel;
    void Start()
    {
        PlayerInfo.Instance.OnPlayerInfoChangedEvent += this.OnPlayerInfoChangedEvent;
        slider_happiness = transform.Find("Bar_Happiness").GetComponent<Slider>();
        slider_energy = transform.Find("Bar_Energy").GetComponent<Slider>();
        slider_heathy = transform.Find("Bar_Health").GetComponent<Slider>();
        partyPosition = transform.Find("PartyPosition").GetComponent<Image>();
        time = transform.Find("Text_Time").GetComponent<Text>();
        money = transform.Find("Text_Money").GetComponent<Text>();
        daysLeft = transform.Find("Text_Date").GetComponent<Text>();
        menu = transform.Find("Menu").GetComponent<Button>();
        menu.onClick.AddListener(delegate { GameBasicPanelUI.Instance.ShowMenuPanel();});
        showInfoPanel = transform.Find("Button_ShowInfoPanel").GetComponent<Button>();
        showInfoPanel.onClick.AddListener(delegate { GameBasicPanelUI.Instance.ShowPlayerInfoPanel(); });

    }

    void OnPlayerInfoChangedEvent(INFOTYPE type)
    {
        if (type == INFOTYPE.All)
            UpdateAllReRender();
    }

    void UpdateAllReRender()
    {
        UpdateBarRender();
        UpdatePartyRender();
        UpdateMoneyRender();
        UpdateLeftDaysRender();
    }

    void UpdateBarRender()
    {
        slider_happiness.value = PlayerInfo.Instance.happiness;
        slider_energy.value = PlayerInfo.Instance.energy;
        slider_heathy.value = PlayerInfo.Instance.healthy;
    }

    void UpdatePartyRender()
    {
        
        if(PlayerInfo.Instance.partyPosition == null)
        {
            partyPosition.gameObject.SetActive(false);
        }
    }

    void UpdateTimeRender()
    {
        time.text = TimeEvent.Instance.GetTimeFor12h(PlayerInfo.Instance.time);
    }

    void UpdateMoneyRender()
    {
        money.text = "$ " + PlayerInfo.Instance.money;
    }

    void UpdateLeftDaysRender()
    {
        daysLeft.text = PlayerInfo.Instance.totalDays - PlayerInfo.Instance.survivalDays + " 天";
    }
}