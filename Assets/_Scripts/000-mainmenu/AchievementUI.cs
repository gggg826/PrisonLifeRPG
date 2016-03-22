/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;

public class AchievementUI : UnitySingletonG<AchievementUI>
{
    public BaseAchievementPanel[] list;
    public DescriptionPanelUI desPanelUI;
    private Animation anim;

    void Awake()
    {
        _instance = this;
    }

    void Start()
    {
        
        desPanelUI = transform.Find("DescriptionPanel").GetComponent<DescriptionPanelUI>();
        AchievementsController.Instance.des = desPanelUI;
        anim = GetComponent<Animation>();
    }

    public void ShowPanel()
    {
        this.gameObject.SetActive(true);
        anim.Play("PaperUp");
    }

    public void HidePanel()
    {
        anim.Play("PaperDown");
    }

    //public void ShowDesPanel(Sprite sprite, string str)
    //{
    //    desPanelUI.ShowPanel(sprite, str);
    //}

    public void GoAhead(int pageNO)
    {
        list[pageNO].TurnLeft();
    }

    public void GoBack(int pageNO)
    {
        list[pageNO-1].TurnRighe();
    }
}