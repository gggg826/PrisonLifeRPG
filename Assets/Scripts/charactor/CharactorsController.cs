/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;

public class CharactorsController : UnitySingletonG<CharactorsController>
{

    public void AddRoleToScreen(string name, Transform parent)
    {
        if (CommonDATA.LoadType == LOADDATETYPE.XMLFILE)
            CharactorView.Instance.RenderRole(CharactorProxy.Instance.GetRoleInfoByName(name), parent);

        else if (CommonDATA.LoadType == LOADDATETYPE.SQLiteDB)
            CharactorView.Instance.RenderRole(CharactorProxy.Instance.GetRoleDBByName(name), parent);
    }

    public void AddAllRolesToScreen(Transform parent)
    {
        if (CommonDATA.LoadType == LOADDATETYPE.XMLFILE)
        {
            foreach (var item in CommonDATA.RolseInfo)
            {
                AddRoleToScreen(item.Key, parent);
            }
        }
        
        else if(CommonDATA.LoadType == LOADDATETYPE.SQLiteDB)
        {
            foreach (var item in CommonDATA.GetAllRoleName("RolseInfo"))
            {
                AddRoleToScreen(item.ToString(), parent);
            }
        }
    }
}