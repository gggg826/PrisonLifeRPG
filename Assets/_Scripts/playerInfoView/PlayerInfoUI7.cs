/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;

public class PlayerInfoUI7 : BasePlayerInfoSingleUI
{
    private Transform grid;
    void Start()
    {
        pageNO = 7;
        base.Init();
        base.ClickButtonEvent();

        grid = transform.Find("Image/Panel/Grid").transform;

    }

    public override void InitInfo()
    {
        // CharactorsController.Instance.AddHeadIconToScreen("小聪明", grid);
        SetEscapeList(grid);
    }

    void SetEscapeList(Transform parent)
    {
        if (PlayerInfo.Instance.escapTeamList == null || PlayerInfo.Instance.escapTeamList == "")
        {
            foreach (RectTransform item in parent.GetComponentsInChildren<RectTransform>())
            {
                if (item.parent == grid)
                    GameObject.Destroy(item.gameObject);
            }
            return;
        }

        foreach (string item in PlayerInfo.Instance.escapTeamList.Split(','))
        {
            CharactorsController.Instance.AddHeadIconToScreen(item, parent);
        }
    }
}