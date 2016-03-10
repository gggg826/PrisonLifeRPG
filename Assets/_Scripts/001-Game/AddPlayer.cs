/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using System.Collections;

public class AddPlayer : MonoBehaviour
{
    void Start()
    {
        if(DATAManager.GameLoadType == GAMELOADTYPE.NewGame)
        {
            PlayerInfo.Instance.BeginNewGame(DATAManager.PLAYER);
        }
        
        else
        {
            PlayerInfo.Instance.Load();
        }
        
        CharactorsController.Instance.AddRoleToScreen(DATAManager.PLAYER, transform);

        print(PlayerPrefs.GetString("playerName"));
    }
}