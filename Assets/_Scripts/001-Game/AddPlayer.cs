/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;

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
        
        CharactorsController.Instance.AddPlayerToScreen(DATAManager.PLAYER, transform);

        print(PlayerPrefs.GetString("playerName"));
    }
    
    void Update()
    {
        if(Input.GetMouseButtonDown(1))
            // PlayerInfo.Instance.EnergyChange(-5);
            PlayerInfo.Instance.DaySurvivalChange();
    }
}