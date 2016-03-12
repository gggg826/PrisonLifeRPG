/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;
using System.Collections;

public class PageUI1 : BaseAchievementPanel
{
	void Start ()
    {
        pageNO = 1;
        base.InitBaseAchievementPanel();
        base.ListICON(1, 20);
        base.ClickButtonEvent();
	}
}