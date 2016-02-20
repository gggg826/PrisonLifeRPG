/*****************************
*
*  Author : TheNO.5
*
******************************/

using UnityEngine;
using System.Collections.Generic;

public static class CommonDATA
{
    private static  Dictionary<string, string[]> _ROLESINFO = XMLOpration.GetRolesInfoDictionary(Application.streamingAssetsPath + "/RoleInfo.xml");
    public static Dictionary<string, string[]> ROLESINFO{get{return _ROLESINFO;}}
}