/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;
using System.Collections;

public class PlayerInfoUI2 : BasePlayerInfoSingleUI
{
    void Start()
    {
        pageNO = 2;
        base.Init();
        base.ClickButtonEvent();
    }
}