/*****************************
*
*  Author : TheNO.5
*
******************************/

using UnityEngine;
using System.Collections.Generic;

public static class CommonDATA
{
    private static  Dictionary<string, CharactorModel> _ROLESINFO = XMLOpration.GetRolesInfoDictionary(Application.streamingAssetsPath + "/RoleInfo.xml");
    public static Dictionary<string, CharactorModel> ROLESINFO{get{return _ROLESINFO;}}

    public enum PREFABKIND
    {
        Body_up,
        Leg_up
    }

    public enum ROLESTATUS
    {
        Idle
    }
}