/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using System.Collections.Generic;

public class CharactorProxy : UnitySingletonG<CharactorProxy>
{
    public Dictionary<string, CharactorModel> rolesDic = CommonDATA.ROLESINFO;

    public CharactorModel GetRoleInfoByName(string name)
    {
        CharactorModel roleInfo;
        rolesDic.TryGetValue(name, out roleInfo);
        return roleInfo;
    }

    public void AddRoleToScreen(string name, Transform parent)
    {
        CharactorView.Instance.RenderRole(CharactorProxy.Instance.GetRoleInfoByName(name), parent);
    }

    public void AddAllRolesToScreen(Transform parent)
    {
        foreach (var item in CharactorProxy.Instance.rolesDic)
        {
            AddRoleToScreen(item.Key, parent);
        }
    }
}