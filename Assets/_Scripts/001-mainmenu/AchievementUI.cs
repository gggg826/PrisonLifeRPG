/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using System.Collections;

public class AchievementUI : UnitySingletonG<AchievementUI>
{
    public BasePageUI[] list;
    private DescriptionPanelUI desPanelUI;
    private Animation animation;

    void Awake()
    {
        _instance = this;
    }

    void Start()
    {
        desPanelUI = transform.Find("DescriptionPanel").GetComponent<DescriptionPanelUI>();
        animation = GetComponent<Animation>();
    }

    public void ShowPanel()
    {
        animation.Play("PaperUp");
    }

    public void HidePanel()
    {
        animation.Play("PaperDown");
    }

    public void ShowDesPanel(Sprite sprite, string str)
    {
        desPanelUI.ShowPanel(sprite, str);
    }

    public void GoAhead(int pageNO)
    {
        list[pageNO].TurnLeft();
    }

    public void GoBack(int pageNO)
    {
        list[pageNO-1].TurnRighe();
    }
}