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
    private DitalSkillInfoUI ditalPanel;
    void Start()
    {
        pageNO = 2;
        base.Init();
        base.ClickButtonEvent();

        list = transform.Find("Image_skillList/Panel/SkillList").transform;
        workPlace = transform.Find("Image_job/Image").GetComponent<Image>();
        cell = transform.Find("Image_cell/Image").GetComponent<Image>();
        ditalPanel = transform.Find("DitalSkillInfoPanel").GetComponent<DitalSkillInfoUI>();


        foreach (string item in PlayerInfo.Instance.skillList.Split(','))
        {
            print(item);
            SkillManager.Instance.AddSkillToScreenl(item, list);
        }
        SkillManager.Instance.SetDitalPanel(ditalPanel);
        workPlace.sprite = TexturesManager.IconBundle.LoadAsset<Sprite>(PlayerInfo.Instance.workPlace);
        cell.sprite = TexturesManager.IconBundle.LoadAsset<Sprite>(PlayerInfo.Instance.jailRoomType);
    }
}