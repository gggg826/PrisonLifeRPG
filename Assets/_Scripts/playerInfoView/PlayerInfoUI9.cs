/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;

public class PlayerInfoUI9 : BasePlayerInfoSingleUI
{
    private Transform grid;
    void Start()
    {
        pageNO = 9;
        base.Init();
        base.ClickButtonEvent();
        
        grid = transform.Find("Image/Panel/Grid").transform;
    }

    public override void InitInfo()
    {
        // CharactorsController.Instance.AddHeadIconToScreen("小聪明", grid);
        SetVictimList(grid);
    }

    void SetVictimList(Transform parent)
    {
        if (PlayerInfo.Instance.victimList == null || PlayerInfo.Instance.victimList == "")
        {
            foreach (RectTransform item in parent.GetComponentsInChildren<RectTransform>())
            {
                if (item.parent == grid)
                    GameObject.Destroy(item.gameObject);
            }
            return;
        }

        foreach (string item in PlayerInfo.Instance.victimList.Split(','))
        {
            CharactorsController.Instance.AddHeadIconToScreen(item, parent);
        }
    }
}