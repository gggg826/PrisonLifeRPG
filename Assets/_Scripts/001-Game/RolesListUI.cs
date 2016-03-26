/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using System.Collections.Generic;

public class RolesListUI : MonoBehaviour 
{
    public Transform[] transArr;
    
	void Start () 
    {
	    AddRoleToList();
	}
    
    public void AddRoleToList()
    {
        List<string> temp = DATAManager.GetAllRoleName("RoleInfo", "GangName");
        LET.ReSortStringList(temp);
        for (int i = 0; i < transArr.Length; i++)
        {
            CharactorsController.Instance.AddRoleToScreen("RoleInfo", temp[i], ROLESTATUS.Normal ,transArr[i], 1);
        }
    }
}