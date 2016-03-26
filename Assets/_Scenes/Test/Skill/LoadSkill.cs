/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;

public class LoadSkill : MonoBehaviour
{
    public Transform parent;

	void Start ()
    {
        foreach (string skill in DATAManager.GetAllRoleName("Skill", "Name"))
        {
            SkillManager.Instance.AddSkillToScreenl(skill, parent);
        }
	}
}