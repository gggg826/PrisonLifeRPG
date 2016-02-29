/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;

public class LoadAchievements : MonoBehaviour
{
    public Transform parent;
    void Start()
    {
        AchievementsController.Instance.AddAchievementToScreen(1, 19, parent);
    }
}