/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;
using System.Collections;

public class LoadSkill : MonoBehaviour
{
    public Transform parent;

	void Start ()
    {
        foreach (string skill in DATAManager.GetAllRoleName("Skill"))
        {
            SkillManager.Instance.ShowSkill(skill, parent);
        }
	}
}