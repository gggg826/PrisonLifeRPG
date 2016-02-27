/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CharactorBordItem : BaseChractorItem
{
    private Image bord;

    void Awake()
    {
        base.LoadSprite();
        bord = transform.Find("ButtonImage").GetComponent<Image>();
    }

    /// <summary>
    /// 初始化Prefab
    /// </summary>
    /// <param name="name"></param>
    /// <param name="model"></param>
    /// <param name="_bord"></param>
    public void InitBordItem(string name, CharactorModel model, Sprite _bord)
    {
        base.InitSpriteShow(name, model);
        bord.overrideSprite = _bord;
    }
}