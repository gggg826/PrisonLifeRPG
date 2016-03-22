/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using UnityEngine.UI;

public class DescriptionPanelUI : MonoBehaviour
{
    private Button closeButton;
    private Image ICON;
    private Text description;
    private Animation anim;

    void Start()
    {
        closeButton = GetComponent<Button>();
        closeButton.onClick.AddListener(delegate { HidePanel(); });
        ICON = transform.Find("Image2/Image_ICON").GetComponent<Image>();
        description = transform.Find("Image2/Text_Description").GetComponent<Text>();
        anim = GetComponent<Animation>();
    }

    public void Init(Sprite sprite, string str)
    {
        ICON.sprite = sprite;
        description.text = str;
    }

    void HidePanel()
    {
        anim.Play("PaperDown");
    }

    public void ShowPanel(Sprite sprite, string str)
    {
        Init(sprite, str);
        anim.Play("PaperUp");
    }
}