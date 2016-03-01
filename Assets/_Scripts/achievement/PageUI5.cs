/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;
using System.Collections;

public class PageUI5 : BasePageUI
{
    void Start()
    {
        pageNO = 5;
        base.Init();
        base.ListICON(81, 100);
        base.ClickButtonEvent();
    }
}