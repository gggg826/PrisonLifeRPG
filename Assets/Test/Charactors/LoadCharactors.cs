/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;

public class LoadCharactors : MonoBehaviour
{
    public Transform parent;
	void Start ()
    {
        // CommonDATA.LoadType = LOADDATETYPE.XMLFILE;
        // CharactorsController.Instance.AddRoleToScreen("GEEK", parent);
        // CharactorsController.Instance.AddAllRolesToScreen(parent);

        CommonDATA.LoadType = LOADDATETYPE.SQLiteDB;
        CharactorsController.Instance.AddRoleToScreen("GEEK", parent);
        CharactorsController.Instance.AddAllRolesToScreen(parent);
        
    }
}