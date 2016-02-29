/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;
using System.Collections;

public class PageUI6 : BasePageUI
{
    void Start()
    {
        pageNO = 6;
        base.Init();
        base.ListICON(1, 20);
        base.ClickButtonEvent();
    }
}