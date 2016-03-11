/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfoPanelUI : MonoBehaviour
{
    public BasePageUI[] list;
    private Animation anim;
 
    void Start()
    {
        anim = GetComponent<Animation>();
    }

    public void ShowPanel()
    {
        this.gameObject.SetActive(true);
        anim.Play("PaperUp");
    }

    public void HidePanel()
    {
        anim.Play("PaperDown");
    }

    public void GoAhead(int pageNO)
    {
        list[pageNO].TurnLeft();
    }

    public void GoBack(int pageNO)
    {
        list[pageNO - 1].TurnRighe();
    }
}