/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;
using System.Collections;

public class PageUI2 : BasePageUI
{
	void Start ()
    {
        pageNO = 2;
        base.Init();
        base.ListICON(21, 40);
        base.ClickButtonEvent();
    }
}