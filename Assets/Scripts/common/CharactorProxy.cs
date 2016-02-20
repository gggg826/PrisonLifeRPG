/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using System.Collections.Generic;

public class CharactorProxy : MonoBehaviour
{
    public Transform canvasTran;
    private Dictionary<string, string[]> rolesInfoDic;
    void Start()
    {
        rolesInfoDic = CommonDATA.ROLESINFO;
        // AddRoleToScreen("GEEK");
        AddAllRoleToScreen();
    }

    string[] GetRoleInfoByName(string name)
    {
        string[] roleInfo;
        rolesInfoDic.TryGetValue(name, out roleInfo);
        return roleInfo;
    }

    void AddRoleToScreen(string name)
    {
        // { headNo, bodyType, skinColor, prefabKind }
        string[] info = GetRoleInfoByName(name);
        string prefabName;
        
        if(info[3] == "Leg_up")
            prefabName = "Leg_up";
        else
            prefabName = "Body_up";
        
        GameObject go = (GameObject)Instantiate(Resources.Load("Prefabs/" + prefabName));
        go.transform.SetParent(canvasTran);
        go.transform.localPosition = Vector3.zero;
        CharactorUI charUI = go.GetComponent<CharactorUI>();
        charUI.InitCharactorUI(name, info);
    }
    
    void AddAllRoleToScreen()
    {
        foreach(var item in rolesInfoDic)
        {
            AddRoleToScreen(item.Key);
        }
    }
}