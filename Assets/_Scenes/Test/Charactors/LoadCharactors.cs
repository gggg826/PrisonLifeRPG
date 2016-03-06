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
        // DATAManager.LoadType = LOADDATETYPE.XMLFILE;
        // CharactorsController.Instance.AddRoleToScreen("RoleInfo", "GEEK", ROLESTATUS.Naked, parent);
        // CharactorsController.Instance.AddAllRolesToScreen("RoleInfo",ROLESTATUS.Normal, parent);

        DATAManager.LoadType = LOADDATETYPE.SQLiteDB;
        CharactorsController.Instance.SetRoleInfoPanel(transform.Find("RoleInfoPanel").GetComponent<RoleInfoPanelUI>());
        CharactorsController.Instance.AddRoleToScreen("RoleInfo","宅男", ROLESTATUS.Naked, parent);
        CharactorsController.Instance.AddAllRolesToScreen("RoleInfo", ROLESTATUS.Normal, parent);
        CharactorsController.Instance.AddAllRolesToScreen("NPCInfo", ROLESTATUS.Normal, parent);

    }
    
    void OnGUI()
    {
        GUI.BringWindowToBack(0);
    }
}