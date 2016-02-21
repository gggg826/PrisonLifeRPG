/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;
using System.Collections;

public class LoadCharactors : MonoBehaviour
{
    public Transform parent;
	void Start ()
    {
        //CharactorsController.Instance.AddRoleToScreen("GEEK", parent);
        CharactorsController.Instance.AddAllRolesToScreen(parent);
    }
}