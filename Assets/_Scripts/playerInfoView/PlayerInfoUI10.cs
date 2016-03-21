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
    void Start()
    {
        pageNO = 10;
        base.Init();
        base.ClickButtonEvent();

        grid = transform.Find("Image/Panel/Grid").transform;
        AchievementsController.Instance.AddSingleAchievementToScreen("那位帅哥", grid);

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