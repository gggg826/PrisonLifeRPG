/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using UnityEngine.UI;

public class BasePaPerTweenPanel : MonoBehaviour
{
    protected Animation anim;

    protected Button close;

    protected void BaseInit()
    {
        anim = GetComponent<Animation>();
        close = transform.Find("Close").GetComponent<Button>();
        close.onClick.AddListener(delegate { HidePanel(); });
    }

    protected void UP()
    {
        anim.Play("PaperUp");
    }

    protected void DOWN()
    {
        anim.Play("PaperDown");
    }

    protected void Left()
    {
        anim.Play("PaperGoLeft");
    }

    protected void Right()
    {
        anim.Play("PaperGoDown");
    }

    protected virtual void HidePanel()
    {

    }
}