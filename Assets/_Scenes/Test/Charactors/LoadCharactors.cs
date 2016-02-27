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
        CommonDATA.LoadType = LOADDATETYPE.XMLFILE;
        CharactorsController.Instance.AddRoleToScreen("GEEK", ROLESTATUS.Naked, parent);
        CharactorsController.Instance.AddAllRolesToScreen(ROLESTATUS.Normal, parent);

        CommonDATA.LoadType = LOADDATETYPE.SQLiteDB;
        CharactorsController.Instance.AddRoleToScreen("GEEK", ROLESTATUS.Naked, parent);
        CharactorsController.Instance.AddAllRolesToScreen(ROLESTATUS.Normal, parent);
        
    }
    
    void OnGUI()
    {
        GUI.BringWindowToBack(0);
    }
}