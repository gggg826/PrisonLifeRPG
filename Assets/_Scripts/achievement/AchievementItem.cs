/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using UnityEngine.UI;

public class AchievementItem : MonoBehaviour
{
    public string Name;
    private Image BGICON;
    private Image ICON;
    private Button button;
    //private int status;
    private string description;

    void Awake()
    {
        BGICON = GetComponent<Image>();
        ICON = transform.Find("Image").GetComponent<Image>();
        button = GetComponent<Button>();
        //button.onClick.AddListener(delegate { ButtonManager.Instance.SendMessage("OnSkillICONClick", )})
    }

    public void InitItem(string[] info)
    {
        Name = info[0];
        ICON.overrideSprite = Resources.Load<Sprite>("Textures/cn/" + info[1]);
        if (info[2] == "1")
        {
            BGICON.color = new Vector4(255, 255, 255, 255);
            ICON.color = new Vector4(255, 255, 255, 255);
        }
        description = info[3];
    }
}