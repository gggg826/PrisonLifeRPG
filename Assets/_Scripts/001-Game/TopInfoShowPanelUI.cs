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
    void Start()
    {
        PlayerInfo.Instance.OnPlayerInfoChangedEvent += this.OnPlayerInfoChangedEvent;
        slider_happiness = transform.Find("Bar_Happiness").GetComponent<Slider>();
        slider_energy = transform.Find("Bar_Energy").GetComponent<Slider>();
        slider_heathy = transform.Find("Bar_Health").GetComponent<Slider>();

        menu = transform.Find("Menu").GetComponent<Button>();
        menu.onClick.AddListener(delegate { BasePanelUI.Instance.ShowMenuPanel();});

    }

    void OnPlayerInfoChangedEvent(INFOTYPE type)
    {
        if (type == INFOTYPE.All||type == INFOTYPE.PlayerInfo)
            ReRenderPanelShow();
    }

    void ReRenderPanelShow()
    {
        slider_happiness.value = PlayerInfo.Instance.happiness;
        slider_energy.value = PlayerInfo.Instance.energy;
        slider_heathy.value = PlayerInfo.Instance.healthy;
    }
}