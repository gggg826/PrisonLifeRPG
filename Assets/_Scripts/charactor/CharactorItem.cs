﻿/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CharactorItem : BaseChractorItem
{
    private Animation animation;

    void Awake()
    {
        base.LoadSprite();
    }
    
    /// <summary>
    /// 初始化Prefab
    /// </summary>
    /// <param name="name"></param>
    /// <param name="model"></param>
    public void InitCharactorItem(string name, CharactorModel model)
    {
        base.InitSpriteShow(name, model);
    }
}