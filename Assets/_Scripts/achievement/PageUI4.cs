/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;
using System.Collections;

public class PageUI4 : BasePageUI
{
    void Start()
    {
        pageNO = 4;
        base.Init();
        base.ListICON(61, 80);
        base.ClickButtonEvent();
    }
}