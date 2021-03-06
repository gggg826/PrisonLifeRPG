﻿/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using UnityEngine.UI;

public class SkillItem : MonoBehaviour
{
    private Image bg;
    public Image spriteIcon;
    public Button button;

    void Awake()
    {
        bg = GetComponent<Image>();
        spriteIcon = transform.Find("Image").GetComponent<Image>();
        button = GetComponent<Button>();
    }

    public void Init(SkillModel model)
    {
        bg.sprite = TexturesManager.IconBundle.LoadAsset<Sprite>("b_btm 1");
        spriteIcon.sprite = TexturesManager.IconBundle.LoadAsset<Sprite>(model.spriteIcon);
        button.onClick.AddListener(delegate { SkillManager.Instance.SendMessage("ShowSkillDital", model);});
    }
}