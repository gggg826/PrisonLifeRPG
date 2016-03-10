/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;
using UnityEngine.UI;

public class BasePanelUI : MonoBehaviour
{
    private MenuPanelUI menuPanelUI;

    private Slider slider_happiness;
    private Slider slider_energy;
    private Slider slider_heathy;

    private Button menu;

	void Start ()
    {
        menuPanelUI = transform.Find("MenuPanel").GetComponent<MenuPanelUI>();

        PlayerInfo.Instance.OnPlayerInfoChangedEvent += this.OnPlayerInfoChangedEvent;
        slider_happiness = transform.Find("TopUIPanel/Bar_Happiness").GetComponent<Slider>();
        slider_energy = transform.Find("TopUIPanel/Bar_Energy").GetComponent<Slider>();
        slider_heathy = transform.Find("TopUIPanel/Bar_Health").GetComponent<Slider>();

        menu = transform.Find("TopUIPanel/Menu").GetComponent<Button>();
        menu.onClick.AddListener(delegate { menuPanelUI.ShowPanel(); });
    }

    void OnPlayerInfoChangedEvent(INFOTYPE type)
    {
        if (type == INFOTYPE.TopUIInfo)
            ReRenderPanelShow();
    }

    void ReRenderPanelShow()
    {
        slider_happiness.value = PlayerInfo.Instance.happiness;
        slider_energy.value = PlayerInfo.Instance.energy;
        slider_heathy.value = PlayerInfo.Instance.healthy;
    }
}