/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using System.Collections;

public class PlayerInfoUI10 : BasePlayerInfoSingleUI
{
    private Transform grid;
    private DescriptionPanelUI des;
    void Start()
    {
        pageNO = 10;
        base.Init();
        base.ClickButtonEvent();


        des = transform.Find("DescriptionPanel").GetComponent<DescriptionPanelUI>();
        AchievementsController.Instance.des = des;
        grid = transform.Find("Image/Panel/Grid").transform;
        AchievementsController.Instance.AddSingleAchievementToScreen("那位帅哥", grid);

    }

    public override void InitInfo()
    {
        SetAchievementsList(grid);
    }

    void SetAchievementsList(Transform parent)
    {
        if (PlayerInfo.Instance.achievementsList == null || PlayerInfo.Instance.achievementsList == "")
        {
            foreach (RectTransform item in parent.GetComponentsInChildren<RectTransform>())
            {
                if (item.parent == grid)
                    GameObject.Destroy(item.gameObject);
            }
            return;
        }

        foreach (string item in PlayerInfo.Instance.achievementsList.Split(','))
        {
            CharactorsController.Instance.AddHeadIconToScreen(item, parent);
        }
    }
}