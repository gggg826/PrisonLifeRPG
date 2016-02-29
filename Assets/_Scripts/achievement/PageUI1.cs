/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;
using System.Collections;

public class PageUI1 : BasePageUI
{
	void Start ()
    {
        pageNO = 1;
        base.Init();
        base.ListICON(1, 20);
        base.ClickButtonEvent();
	}
}