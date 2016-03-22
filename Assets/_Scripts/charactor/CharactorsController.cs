/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;

public class CharactorsController : UnitySingletonG<CharactorsController>
{

    private RoleInfoPanelUI roleInfoPanel;
    private CharactorItem currentItem;
    /// <summary>
    /// 添加一个角色渲染
    /// </summary>
    /// <param name="name"></param>
    /// <param name="status"></param>
    /// <param name="parent"></param>
    public void AddRoleToScreen(string tableName, string name, ROLESTATUS status, Transform parent, int scene)
    {
        // if (DATAManager.LoadType == LOADDATETYPE.XMLFILE)
        //     CharactorView.Instance.RenderRole(CharactorProxy.Instance.GetRoleInfoByName(name), parent);

        // else if (DATAManager.LoadType == LOADDATETYPE.SQLiteDB)
        CharactorView.Instance.RenderRole(CharactorProxy.Instance.GetModelByName(tableName, name, status), parent, scene);
    }

    public void AddRoleToScreen(string tableName, int id, ROLESTATUS status, Transform parent, int scene)
    {
        CharactorView.Instance.RenderRole(CharactorProxy.Instance.GetModelByRowID(tableName, id, status), parent, scene);
    }

    public void AddRoleToScreen(CharactorModel model, Transform parent, int scene)
    {
        CharactorView.Instance.RenderRole(model, parent, scene);
    }
    
        public void AddPlayerToScreen(CharactorModel model, Transform parent)
    {
        CharactorView.Instance.RenderPlayer(model, parent);
    }

    /// <summary>
    /// 添加数据库中所有角色的渲染
    /// </summary>
    /// <param name="status"></param>
    /// <param name="parent"></param>
    public void AddAllRolesToScreen(string tableName, ROLESTATUS status, Transform parent, int scene)
    {
        if (DATAManager.LoadType == LOADDATETYPE.XMLFILE)
        {
            foreach (var item in DATAManager.RolseInfo)
            {
                AddRoleToScreen(tableName, item.Key, status, parent, scene);
            }
        }

        else if (DATAManager.LoadType == LOADDATETYPE.SQLiteDB)
        {
            foreach (var item in DATAManager.GetAllRoleName(tableName))
            {
                AddRoleToScreen(tableName, item.ToString(), status, parent, scene);
            }
        }
    }

    /// <summary>
    /// 添加第一界面带牌小人的渲染
    /// </summary>
    /// <param name="name"></param>
    /// <param name="status"></param>
    /// <param name="sprite">牌图片名称</param>
    /// <param name="parent"></param>
    public void AddButtonBordToScreen(string tableName, string name, ROLESTATUS status, Sprite sprite, Transform parent)
    {
        CharactorView.Instance.RenderButtonBord(CharactorProxy.Instance.GetModelByName(tableName, name, status), sprite, parent);
    }

    public void SetRoleInfoPanel(RoleInfoPanelUI panel)
    {
        roleInfoPanel = panel;
    }

    public void ShowRoleInfoPanel(CharactorModel model, CharactorItem item)
    {
        if(currentItem != null)
            currentItem.HideCircle();
        currentItem = item;
        currentItem.ShowCircle();
        roleInfoPanel.ShowPanel(model);
    }
    
    public void AddHeadIconToScreen(string roleName, Transform parent)
    {
        CharactorView.Instance.AddHeadIcon(roleName, parent);
    }
}