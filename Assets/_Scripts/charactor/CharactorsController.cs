/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;

public class CharactorsController : UnitySingletonG<CharactorsController>
{
    /// <summary>
    /// 添加一个角色渲染
    /// </summary>
    /// <param name="name"></param>
    /// <param name="status"></param>
    /// <param name="parent"></param>
    public void AddRoleToScreen(string name, ROLESTATUS status, Transform parent)
    {
        if (DATAManager.LoadType == LOADDATETYPE.XMLFILE)
            CharactorView.Instance.RenderRole(CharactorProxy.Instance.GetRoleInfoByName(name), parent);

        else if (DATAManager.LoadType == LOADDATETYPE.SQLiteDB)
            CharactorView.Instance.RenderRole(CharactorProxy.Instance.GetRoleDBByName(name, status), parent);
    }

    public void AddRoleToScreen(int id, ROLESTATUS status, Transform parent)
    {
        CharactorView.Instance.RenderRole(CharactorProxy.Instance.GetRoleDBByRowID(id, status), parent);
    }

    /// <summary>
    /// 添加数据库中所有角色的渲染
    /// </summary>
    /// <param name="status"></param>
    /// <param name="parent"></param>
    public void AddAllRolesToScreen(ROLESTATUS status, Transform parent)
    {
        if (DATAManager.LoadType == LOADDATETYPE.XMLFILE)
        {
            foreach (var item in DATAManager.RolseInfo)
            {
                AddRoleToScreen(item.Key, status, parent);
            }
        }

        else if (DATAManager.LoadType == LOADDATETYPE.SQLiteDB)
        {
            foreach (var item in DATAManager.GetAllRoleName())
            {
                AddRoleToScreen(item.ToString(), status, parent);
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
    public void AddButtonBordToScreen(string name, ROLESTATUS status, Sprite sprite, Transform parent)
    {
        CharactorView.Instance.RenderButtonBord(CharactorProxy.Instance.GetRoleDBByName(name, status), sprite, parent);
    }

    public void ShowRoleInfoPanel(string name)
    {
        print(name);
    }
}