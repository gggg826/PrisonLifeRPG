﻿/*****************************
*
*  Author : TheNO.5
*
******************************/



public class FirstSceneUIView : UnitySingletonG<FirstSceneUIView>
{
    public BGUI bgUI;
    public TopPanelUI topPanelUI;
    public BottomPanelUI bottomPanelUI;
    public RoleButtonPanelUI roleButtonPanelUI;
    public LanguagePanelUI languagePanelUI;
    public AchievementUI achievementUI;
    // public RoleInfoPanelUI roleInfoPanelUI;
    public NewGameListUI newGameListUI;

    void Awake()
    {
        _instance = this;
    }

    void Start()
    {
        bgUI = transform.Find("BG").GetComponent<BGUI>();
        topPanelUI = transform.Find("TopPanel").GetComponent<TopPanelUI>();
        bottomPanelUI = transform.Find("BottomPanel").GetComponent<BottomPanelUI>();
        roleButtonPanelUI = transform.Find("RoleButtonPanel").GetComponent<RoleButtonPanelUI>();
        languagePanelUI = transform.Find("LanguageSelectPanel").GetComponent<LanguagePanelUI>();
        // roleInfoPanelUI = transform.Find("RoleInfoPanel").GetComponent<RoleInfoPanelUI>();
        newGameListUI = transform.Find("NewGameList").GetComponent<NewGameListUI>(); 
        achievementUI = AchievementUI.Instance;
        FloatButton.Instance.GetFloatButton();
    }
}