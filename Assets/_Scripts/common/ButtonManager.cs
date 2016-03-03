/*****************************
*
*  Author : TheNO.5
*
******************************/

using UnityEngine;

public class ButtonManager : UnitySingletonG<ButtonManager>
{
    //    语言选择
    void LanguageButtonClick()
    {
        FirstSceneUIView.Instance.languagePanelUI.ShowPanel();
    }

    // 关闭语言选择面板
    void CancelLanguagePanelClick()
    {
        FirstSceneUIView.Instance.languagePanelUI.SendMessage("HidePanel");
        FirstSceneUIView.Instance.bgUI.SendMessage("LanguageButtonIconShow", FirstSceneUIView.Instance.languagePanelUI.currentLanguageSprite);
    }

    //  分享
    void ShareButtonClick()
    {
        print("AirDrop");
    }

    // 评价
    void ReviewsButtonClick()
    {
        print("请评价 -- 调用App Store");
    }

    // 游戏控制中心（Apple）
    void GameCentreButtonClick()
    {
        print("打开游戏控制中心 -- 调用Game Centre");
    }

    // Facebook
    void FacebookButtonClick()
    {
        print("分享到FACEBOOK");
    }

    // Twitter
    void TwitterShareButtonClick()
    {
        print("分享到TWITTER");
    }

    // Email
    void EmailButtonClick()
    {
        print("给我发电邮 -- 调用Email");
    }

    //  人物按钮
    void OnspecialButtonClick()
    {
        print("特殊犯人");
    }

    // 新游戏
    void OnnewGameButtonClick()
    {
        print("新游戏");
    }

    //  加载游戏
    void OnloadGameButtonClick()
    {
        print("加载游戏");
    }

    // 历史记录
    void OnhistoryButtonClick()
    {
        Application.LoadLevel(1);
    }

    // 制作组
    void OncreditsButtonClick()
    {
        print("制作组");
    }

    // 成就系统
    void OnnickNameButtonClick()
    {
        AchievementUI.Instance.ShowPanel();
    }

    // 加载场景
    void ChangeSence(int id)
    {
        Application.LoadLevel(id);
    }

    // 显示人物属性面板
    void ShowRoleInfoPanel(CharactorModel model)
    {
        FirstSceneUIView.Instance.roleInfoPanelUI.ShowPanel(model);
    }
}