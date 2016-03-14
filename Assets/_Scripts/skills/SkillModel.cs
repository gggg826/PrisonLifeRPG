/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;
using System.Collections;

public class SkillModel 
{
    public string skillName;
    public string spriteIcon;
    public string needProperty;
    public string point;
    public string des;

    public SkillModel(string _skillName)
    {
        skillName = _skillName;
        spriteIcon = DATAManager.GetTextDBValue("Skill", "Icon", skillName);
        needProperty = DATAManager.GetTextDBValue("Skill", "Need", skillName);
        point = DATAManager.GetTextDBValue("Skill", "Point", skillName);
        des = DATAManager.GetTextDBValue("Skill", "Description", skillName);
    }

}