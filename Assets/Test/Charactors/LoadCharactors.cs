/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;
using Mono.Data.Sqlite;

public class LoadCharactors : MonoBehaviour
{
    public Transform parent;
	void Start ()
    {
        CharactorsController.Instance.AddRoleToScreen("GEEK", parent);
        //CharactorsController.Instance.AddAllRolesToScreen(parent);

        CommonDATA.LoadType = LOADDATETYPE.SQLiteDB;
        CharactorsController.Instance.AddRoleToScreen("GEEK", parent);
    }
}