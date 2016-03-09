/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;
using UnityEngine.UI;

public class BasePanelUI : MonoBehaviour
{
    public Slider slider_happiness;
    public Slider slider_energy;
    public Slider slider_heathy;

	void Start ()
    {
        PlayerInfo.Instance.OnPlayerInfoChangedEvent += this.OnPlayerInfoChangedEvent;
        slider_happiness = transform.Find("TopUIPanel/Bar_Happiness").GetComponent<Slider>();
        slider_energy = transform.Find("TopUIPanel/Bar_Energy").GetComponent<Slider>();
        slider_heathy = transform.Find("TopUIPanel/Bar_Health").GetComponent<Slider>();
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