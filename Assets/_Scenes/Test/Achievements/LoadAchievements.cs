/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;
using System.Collections;

public class LoadAchievements : MonoBehaviour
{
    public Transform parent;
    void Start()
    {
        AchievementsController.Instance.AddAchievementToScreen(1, 10, parent);
    }
}