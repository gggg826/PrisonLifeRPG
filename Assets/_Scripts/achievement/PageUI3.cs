﻿/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;
using System.Collections;

public class PageUI3 : BaseAchievementPanel
{
	void Start ()
    {
        pageNO = 3;
        base.InitBaseAchievementPanel();
        base.ListICON(41, 60);
        base.ClickButtonEvent();
    }
}