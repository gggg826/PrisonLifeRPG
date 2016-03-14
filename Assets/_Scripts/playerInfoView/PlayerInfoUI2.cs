/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfoUI2 : BasePlayerInfoSingleUI
{
    private Transform list;
    private Image workPlace;
    private Image cell;
    void Start()
    {
        pageNO = 2;
        base.Init();
        base.ClickButtonEvent();

        list = transform.Find("Image_skillList/SkillList").transform;
        workPlace = transform.Find("Image_job/Image").GetComponent<Image>();
        cell = transform.Find("Image_cell/Image").GetComponent<Image>();


        foreach (string item in PlayerInfo.Instance.skillList.Split(','))
        {
            SkillManager.Instance.ShowSkill(item, list);
        }
        workPlace.sprite = TexturesManager.IconBundle.LoadAsset<Sprite>(PlayerInfo.Instance.workPlace);
        cell.sprite = TexturesManager.IconBundle.LoadAsset<Sprite>(PlayerInfo.Instance.jailRoomType);
    }
}