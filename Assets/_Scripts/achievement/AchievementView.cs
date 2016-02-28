/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;
using System.Collections;

public class AchievementView : UnitySingletonG<AchievementView>
{
    /// <summary>
    /// 添加单个成就渲染
    /// </summary>
    /// <param name="name"></param>
    /// <param name="parent"></param>
    public void RenderSingleAchievement(string[] info, Transform parent)
    {
        GameObject go = (GameObject)Instantiate(Resources.Load("AchievementICON"));
        go.transform.SetParent(parent);
        go.GetComponent<AchievementItem>().InitItem(info);
    }
}