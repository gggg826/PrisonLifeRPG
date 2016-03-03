﻿/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine.UI;

public class CharactorItem : BaseChractorItem
{
    public Button button;
    void Awake()
    {
        base.LoadSprite();
        button = GetComponent<Button>();
    }
    
    void Start()
    {
        StartCoroutine(base.BeginTween("Idle"));
    }
    
    /// <summary>
    /// 初始化Prefab
    /// </summary>
    /// <param name="name"></param>
    /// <param name="_model"></param>
    public void InitCharactorItem(CharactorModel _model)
    {
        base.InitSpriteShow(_model);
        button.onClick.AddListener(delegate { CharactorsController.Instance.SendMessage("ShowRoleInfoPanel", _model); });
    }
}