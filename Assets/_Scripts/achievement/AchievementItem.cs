/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using UnityEngine.UI;

public class AchievementItem : MonoBehaviour
{
    private string Name;
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
    }

    public void InitItem(string[] info)
    {
        Name = info[0];
        BGICON.sprite = TexturesManager.IconBundle.LoadAsset<Sprite>("b_btm8");
        ICON.sprite = TexturesManager.IconBundle.LoadAsset<Sprite>(info[1]);
        if (info[2] == "1")
        {
            BGICON.color = new Vector4(255, 255, 255, 255);
            ICON.color = new Vector4(255, 255, 255, 255);
        }
        description = info[3];
        button.onClick.AddListener(delegate { AchievementUI.Instance.ShowDesPanel(ICON.sprite, description); });
    }
}