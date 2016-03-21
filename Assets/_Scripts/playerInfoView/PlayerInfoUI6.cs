/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using UnityEngine.UI;

public class PlayerInfoUI6 : BasePlayerInfoSingleUI
{
    private Slider barLeft;
    private Slider barRight;
    void Start()
    {
        pageNO = 6;
        base.Init();
        base.ClickButtonEvent();

        barLeft = transform.Find("Image_guards/Bar/Bar_Left").GetComponent<Slider>();
        barRight = transform.Find("Image_guards/Bar/Bar_Right").GetComponent<Slider>();
    }

    public override void InitInfo()
    {
        SetSlider(barLeft, barRight, PlayerInfo.Instance.snicth);
    }

    void SetSlider(Slider bad, Slider good, int value)
    {
        bad.value = 0;
        good.value = 0;

        if (value < 0)
            bad.value = value;
        else
            good.value = value;
    }
}