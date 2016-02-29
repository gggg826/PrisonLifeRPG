/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;
using System.Collections;

public class PageUI7 : BasePageUI
{
    void Start()
    {
        pageNO = 7;
        base.Init();
        base.ListICON(1, 20);
        base.ClickButtonEvent();
    }
}