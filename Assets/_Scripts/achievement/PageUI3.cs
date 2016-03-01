/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;
using System.Collections;

public class PageUI3 : BasePageUI
{
	void Start ()
    {
        pageNO = 3;
        base.Init();
        base.ListICON(41, 60);
        base.ClickButtonEvent();
    }
}