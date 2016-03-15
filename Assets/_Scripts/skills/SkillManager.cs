/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;
using System.Collections;

public class SkillManager : UnitySingletonG<SkillManager>
{
    private GameObject prefab = Resources.Load<GameObject>("Prefabs/SkillIcon");
    public void ShowSkill(string skillName, Transform parent)
    {
        SkillModel model = new SkillModel(skillName);
        GameObject go = Instantiate(prefab) as GameObject;
        go.transform.SetParent(parent);
        go.transform.localPosition = Vector3.zero;
        go.transform.localScale = Vector3.one;
        SkillItem item = go.GetComponent<SkillItem>();
        item.Init(model.spriteIcon);
    }
}