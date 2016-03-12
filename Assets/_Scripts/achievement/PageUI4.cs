/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;
using System.Collections;

public class PageUI4 : BaseAchievementPanel
{
    void Start()
    {
        pageNO = 4;
        base.InitBaseAchievementPanel();
        base.ListICON(61, 80);
        base.ClickButtonEvent();
    }
}