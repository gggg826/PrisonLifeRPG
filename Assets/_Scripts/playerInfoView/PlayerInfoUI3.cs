﻿/*****************************
*
*  Author : TheNO.5
*
******************************/

using UnityEngine;
using UnityEngine.UI;

public class PlayerInfoUI3 : BasePlayerInfoSingleUI
{
    private Text release;
    private Text totalDays;
    private Text survivalDays;
    private Transform teamList;
    void Start()
    {
        pageNO = 3;
        base.Init();
        base.ClickButtonEvent();
        
        release = transform.Find("Image_release/Text").GetComponent<Text>();
        totalDays = transform.Find("Image_totalDays/Text").GetComponent<Text>();
        survivalDays = transform.Find("Image_survivalDays/Text").GetComponent<Text>();
        teamList = transform.Find("Image_escapTeam/Panel/List").transform;
        
        release.text = PlayerInfo.Instance.release.ToString();
        totalDays.text = PlayerInfo.Instance.totalDays.ToString();
        survivalDays.text = PlayerInfo.Instance.survivalDays.ToString();
        
        if(PlayerInfo.Instance.escapTeamList != null || PlayerInfo.Instance.escapTeamList != "")
        {
            
        }
        
    }
}