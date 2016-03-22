/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;

public class PlayerInfoPanelUI : MonoBehaviour
{
    public BasePlayerInfoSingleUI[] list;
    private Animation anim;
 
    void Start()
    {
        anim = GetComponent<Animation>();
    }

    public void ShowPanel()
    {
        //gameObject.SetActive(true);
        Init();
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
    
    void Init()
    {
        foreach (BasePlayerInfoSingleUI item in list)
        {
            item.InitInfo();
        }
    }
}