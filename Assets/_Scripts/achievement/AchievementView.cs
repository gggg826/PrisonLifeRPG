/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;

public class AchievementView : UnitySingletonG<AchievementView>
{
    /// <summary>
    /// 添加单个成就渲染
    /// </summary>
    /// <param name="name"></param>
    /// <param name="parent"></param>
    public void RenderSingleAchievement(string[] info, Transform parent)
    {
        GameObject go = (GameObject)Instantiate(Resources.Load("Prefabs/AchievementICON"));
        go.transform.SetParent(parent);
        go.transform.position = Vector3.zero;
        go.transform.localScale = Vector3.one;
        go.GetComponent<AchievementItem>().InitItem(info);
    }
}