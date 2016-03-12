/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;
using System.Collections;

public class PlayerInfoUI4 : BasePlayerInfoSingleUI
{
    void Start()
    {
        pageNO = 4;
        base.Init();
        base.ClickButtonEvent();
    }
}