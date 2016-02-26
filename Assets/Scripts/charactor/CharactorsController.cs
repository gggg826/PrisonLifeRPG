/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;

public class CharactorsController : UnitySingletonG<CharactorsController>
{

    public void AddRoleToScreen(string name, ROLESTATUS status, Transform parent)
    {
        if (CommonDATA.LoadType == LOADDATETYPE.XMLFILE)
            CharactorView.Instance.RenderRole(CharactorProxy.Instance.GetRoleInfoByName(name), parent);

        else if (CommonDATA.LoadType == LOADDATETYPE.SQLiteDB)
            CharactorView.Instance.RenderRole(CharactorProxy.Instance.GetRoleDBByName(name, status), parent);
    }

    public void AddAllRolesToScreen(ROLESTATUS status, Transform parent)
    {
        if (CommonDATA.LoadType == LOADDATETYPE.XMLFILE)
        {
            foreach (var item in CommonDATA.RolseInfo)
            {
                AddRoleToScreen(item.Key, status, parent);
            }
        }

        else if (CommonDATA.LoadType == LOADDATETYPE.SQLiteDB)
        {
            foreach (var item in CommonDATA.GetAllRoleName("RolseInfo"))
            {
                AddRoleToScreen(item.ToString(), status, parent);
            }
        }
    }

    public void ChangeRole(CharactorItem roleGo, string name)
    {
        CharactorModel model = CharactorProxy.Instance.GetRoleDBByName(name, ROLESTATUS.Normal);
        CharactorView.Instance.ChangRoleRender(roleGo, model);
    }
}