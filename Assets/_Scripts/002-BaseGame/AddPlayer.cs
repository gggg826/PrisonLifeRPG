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
	    CharactorsController.Instance.AddRoleToScreen("RoleInfo", "小聪明", ROLESTATUS.Naked, transform);
	}
}