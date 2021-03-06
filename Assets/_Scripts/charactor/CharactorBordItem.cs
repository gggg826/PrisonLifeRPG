﻿/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using UnityEngine.UI;

public class CharactorBordItem : BaseChractorItem
{
    private Image bord;

    void Awake()
    {
        base.LoadSprite();
        bord = transform.Find("ButtonImage").GetComponent<Image>();
    }
    
    void Start()
    {
        StartCoroutine(base.BeginTween("ButtonBord"));
    }

    /// <summary>
    /// 初始化Prefab
    /// </summary>
    /// <param name="name"></param>
    /// <param name="model"></param>
    /// <param name="_bord"></param>
    public void InitBordItem(CharactorModel model, Sprite _bord)
    {
        base.InitSpriteShow(model);
        bord.overrideSprite = _bord;
    }
}