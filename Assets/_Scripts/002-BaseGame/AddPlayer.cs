/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using System.Collections;

public class AddPlayer : MonoBehaviour 
{
	void Start () 
    {
        CharactorsController.Instance.AddRoleToScreen("RoleInfo", 1, ROLESTATUS.Naked, transform);
	    //CharactorsController.Instance.AddRoleToScreen(DATAManager.PLAYER, transform);
     //   PlayerInfo.Instance.Begin(DATAManager.PLAYER);
	}
}