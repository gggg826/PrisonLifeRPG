/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfoUI5 : BasePlayerInfoSingleUI
{
    private Image gangIcon;
    private Text gangName;
    private Transform panel1;//老大
    private Transform panel2;
    private Transform panel3;
    private Transform panel4;
    private Slider partyFamSlider;

    void Start()
    {
        pageNO = 5;
        base.Init();
        base.ClickButtonEvent();

        gangIcon = transform.Find("Image_gangIcon").GetComponent<Image>();
        gangName = transform.Find("Image_gangIcon/Text").GetComponent<Text>();
        panel1 = transform.Find("Image_boss/Panel1").transform; 
        panel2 = panel1.Find("Image_leader/Panel2").transform;
        panel3 = panel2.Find("Image_killer/Panel3").transform; 
        panel4 = panel3.Find("Image_member/Panel4").transform;
        partyFamSlider = panel4.Find("Image_fam/Bar_Energy").GetComponent<Slider>();
    }
}