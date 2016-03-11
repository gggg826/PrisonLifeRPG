/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;

public class BasePanelUI : UnitySingletonG<BasePanelUI>
{
    private MenuPanelUI menuPanelUI;

    void Awake()
    {
        _instance = this;
    }

    void Start()
    {
        menuPanelUI = transform.Find("MenuPanel").GetComponent<MenuPanelUI>();
    }
    
    public void ShowMenuPanel()
    {
        menuPanelUI.ShowPanel();
    }
}