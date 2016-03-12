/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;
using System.Collections;

public class PageUI5 : BaseAchievementPanel
{
    void Start()
    {
        pageNO = 5;
        base.InitBaseAchievementPanel();
        base.ListICON(81, 100);
        base.ClickButtonEvent();
    }
}