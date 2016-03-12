/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;
using System.Collections;

public class PageUI2 : BaseAchievementPanel
{
	void Start ()
    {
        pageNO = 2;
        base.InitBaseAchievementPanel();
        base.ListICON(21, 40);
        base.ClickButtonEvent();
    }
}