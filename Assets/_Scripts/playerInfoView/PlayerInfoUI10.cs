/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;
using System.Collections;

public class PlayerInfoUI10 : BasePlayerInfoSingleUI
{
    void Start()
    {
        pageNO = 10;
        base.Init();
        base.ClickButtonEvent();
    }
}