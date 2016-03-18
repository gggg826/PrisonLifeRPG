/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfoUI5 : BasePlayerInfoSingleUI
{
    
    private Slider mobstersBadSlider;
    private Slider mobstersGoodSlider;
    private Slider coinBadSlider;
    private Slider coinGoodSlider;
    private Slider heartBadSlider;
    private Slider heartGoodSlider;
    private Slider roseBadSlider;
    private Slider roseGoodSlider;

    void Start()
    {
        pageNO = 5;
        base.Init();
        base.ClickButtonEvent();
        
        mobstersBadSlider = transform.Find("Image_mobsters/Text/Bar_Relationship/Bar_Left").GetComponent<Slider>();
        mobstersGoodSlider = transform.Find("Image_mobsters/Text/Bar_Relationship/Bar_Right").GetComponent<Slider>();
        
        coinBadSlider = transform.Find("Image_coin/Text/Bar_Relationship/Bar_Left").GetComponent<Slider>();
        coinGoodSlider = transform.Find("Image_coin/Text/Bar_Relationship/Bar_Right").GetComponent<Slider>();
        
        heartBadSlider = transform.Find("Image_heart/Text/Bar_Relationship/Bar_Left").GetComponent<Slider>();
        heartGoodSlider = transform.Find("Image_heart/Text/Bar_Relationship/Bar_Right").GetComponent<Slider>();
        
        roseBadSlider = transform.Find("Image_rose/Text/Bar_Relationship/Bar_Left").GetComponent<Slider>();
        roseGoodSlider = transform.Find("Image_rose/Text/Bar_Relationship/Bar_Right").GetComponent<Slider>();
        
        
        SetSlider(mobstersBadSlider, mobstersGoodSlider, PlayerInfo.Instance.relationWithMobsters);
        SetSlider(coinBadSlider,coinGoodSlider, PlayerInfo.Instance.relationWithCoin);
        SetSlider(heartBadSlider,heartGoodSlider,PlayerInfo.Instance.relationWithHeartBreakers);
        SetSlider(roseBadSlider,roseGoodSlider, PlayerInfo.Instance.relationWithRosesAndGuns);
    }
    
    void SetSlider(Slider bad, Slider good, int value)
    {
        bad.value = 0;
        good.value = 0;
        
        if(value < 0)
            bad.value = value;
        else
            good.value = value;
    }
}