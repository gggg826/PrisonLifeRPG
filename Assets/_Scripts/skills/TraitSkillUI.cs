/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;
using System.Collections;

public class TraitSkillUI : MonoBehaviour
{
    private Animation anim;

    void Start()
    {
        anim = GetComponent<Animation>();
    }

    void ShowPanel()
    {
        anim.Play("PaperUp");
    }

    public void HidePanel()
    {
        anim.Play("PaperDown");
    }

}