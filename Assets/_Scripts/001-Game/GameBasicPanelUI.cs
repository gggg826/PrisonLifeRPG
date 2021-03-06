﻿/*****************************
*
*  Author : TheNO.5
*
******************************/



public class GameBasicPanelUI : UnitySingletonG<GameBasicPanelUI>
{
    private MenuPanelUI menuPanelUI;
    private PlayerInfoPanelUI playerinfoPanelUI;

    void Awake()
    {
        _instance = this;
    }

    void Start()
    {
        menuPanelUI = transform.Find("MenuPanel").GetComponent<MenuPanelUI>();
        playerinfoPanelUI = transform.Find("PlayerInfoPanel").GetComponent<PlayerInfoPanelUI>();
        //playerinfoPanelUI.gameObject.SetActive(false);
    }
    
    public void ShowMenuPanel()
    {
        menuPanelUI.ShowPanel();
    }

    public void ShowPlayerInfoPanel()
    {
        playerinfoPanelUI.ShowPanel(); 
    }
}