﻿/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;
using System.Collections;

public class PageUI6 : BaseAchievementPanel
{
    void Start()
    {
        pageNO = 6;
        base.InitBaseAchievementPanel();
        base.ListICON(101, 120);
        base.ClickButtonEvent();
    }
}