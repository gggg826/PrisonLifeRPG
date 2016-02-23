/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using System.Collections.Generic;

public class CharactorProxy : UnitySingletonG<CharactorProxy>
{
    //public Dictionary<string, CharactorModel> rolesDic = CommonDATA.ROLESINFO;

    /// <summary>
    /// xml
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public CharactorModel GetRoleInfoByName(string name)
    {
        CharactorModel roleInfo;
        CommonDATA.RolseInfo.TryGetValue(name, out roleInfo);
        return roleInfo;
    }


    /// <summary>
    ///Database 
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public CharactorModel GetRoleDBByName(string name)
    {
        return new CharactorModel(name);
    }
}