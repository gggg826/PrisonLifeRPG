/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;

public class PlayerInfoUI8 : BasePlayerInfoSingleUI
{
     private Transform grid;
    void Start()
    {
        pageNO = 8;
        base.Init();
        base.ClickButtonEvent();
        
        grid = transform.Find("Image/Panel/Grid").transform;

    }

    public override void InitInfo()
    {
        // CharactorsController.Instance.AddHeadIconToScreen("小聪明", grid);
        SetEnemyList(grid);
    }
    
     void SetEnemyList(Transform parent)
    {
        if (PlayerInfo.Instance.enemyList == null || PlayerInfo.Instance.enemyList == "")
        {
            foreach (RectTransform item in parent.GetComponentsInChildren<RectTransform>())
            {
                if (item.parent == grid)
                    GameObject.Destroy(item.gameObject);
            }
            return;
        }

        foreach (string item in PlayerInfo.Instance.enemyList.Split(','))
        {
            CharactorsController.Instance.AddHeadIconToScreen(item, parent);
        }
    }
}