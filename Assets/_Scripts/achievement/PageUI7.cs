/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;
using System.Collections;

public class PageUI7 : BaseAchievementPanel
{
    void Start()
    {
        pageNO = 7;
        base.InitBaseAchievementPanel();
        base.ListICON(121, 135);
        base.ClickButtonEvent();
    }
}