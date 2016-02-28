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
        DATAManager.LoadType = LOADDATETYPE.XMLFILE;
        CharactorsController.Instance.AddRoleToScreen("GEEK", ROLESTATUS.Naked, parent);
        CharactorsController.Instance.AddAllRolesToScreen(ROLESTATUS.Normal, parent);

        DATAManager.LoadType = LOADDATETYPE.SQLiteDB;
        CharactorsController.Instance.AddRoleToScreen("GEEK", ROLESTATUS.Naked, parent);
        CharactorsController.Instance.AddAllRolesToScreen(ROLESTATUS.Normal, parent);
        
    }
    
    void OnGUI()
    {
        GUI.BringWindowToBack(0);
    }
}