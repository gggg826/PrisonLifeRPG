/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;
using System.Collections;

public class PlayerInfoUI5 : BasePlayerInfoSingleUI
{
    void Start()
    {
        pageNO = 5;
        base.Init();
        base.ClickButtonEvent();
    }
}