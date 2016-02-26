/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using UnityEngine.UI;

public class ButtonBordItem : MonoBehaviour
{
    private CharactorItem item;
    private Image bord;

    void Awake()
    {
        item = transform.Find("Body_up").GetComponent<CharactorItem>();
        bord = transform.Find("ButtonImage").GetComponent<Image>();
    }

    public void InitBordItem(string roleName, Sprite image)
    {
        CharactorsController.Instance.ChangeRole(item, roleName);
        bord.overrideSprite = image;
    }
}