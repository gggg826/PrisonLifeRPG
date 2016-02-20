/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;

public class CharactorsController: UnitySingletonG<CharactorsController>
{

    public void AddRoleToScreen(string name, Transform parent)
    {
        CharactorView.Instance.RenderRole(CharactorProxy.Instance.GetRoleInfoByName(name), parent);
    }

    public void AddAllRolesToScreen(Transform parent)
    {
        foreach(var item in CharactorProxy.Instance.rolesDic)
        {
            AddRoleToScreen(item.Key, parent);
        }
    }
}