/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;

public class AchievementsController : UnitySingletonG<AchievementsController>
{
    public DescriptionPanelUI des;

    public void AddSingleAchievementToScreen(string name, Transform parent)
    {
        AchievementView.Instance.RenderSingleAchievement(DATAManager.GetSingleAchievementInfo("Name", name), parent);
    }

    public void AddAchievementToScreen(int startID, int endID, Transform parent)
    {
        for(int i = startID; i <= endID; i++)
        {
            AchievementView.Instance.RenderSingleAchievement(DATAManager.GetSingleAchievementInfo(i), parent);
        }
    }
    
    public void ShowDesPanel( Sprite sprite, string str)
    { 
        des.ShowPanel(sprite, str);
    }
}