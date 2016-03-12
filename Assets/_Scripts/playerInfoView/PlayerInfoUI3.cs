/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;
using System.Collections;

public class PlayerInfoUI3 : BasePlayerInfoSingleUI
{
    void Start()
    {
        pageNO = 3;
        base.Init();
        base.ClickButtonEvent();
    }
}