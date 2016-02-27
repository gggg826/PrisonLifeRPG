/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using UnityEngine.UI;

public class LanguagePanelUI : MonoBehaviour
{
    public Button cancelButton;
    public Button ENButton;
    public Button FRButton;
    public Button SCNButton;
    public Button UNSCNButton;
    public Image ENIcon;
    public Image FRIcon;
    public Image SCNIcon;
    public Image UNSCNIcon;
    public Sprite enSprite1;
    public Sprite enSprite2;
    public Sprite frSprite1;
    public Sprite frSprite2;
    public Sprite scnSprite1;
    public Sprite scnSprite2;
    public Sprite unscnSprite1;
    public Sprite unscnSprite2;
    public Sprite currentLanguageSprite;

    void Start()
    {
        cancelButton = transform.Find("CancelButton").GetComponent<Button>();
        cancelButton.onClick.AddListener(delegate { ButtonManager.Instance.SendMessage("CancelLanguagePanelClick"); });


        currentLanguageSprite = FirstSceneUIView.Instance.bgUI.GetlanguageCurrentSprite();


        enSprite1 = Resources.Load<Sprite>("Textures/001-mainmenu/b_language_en1");
        enSprite2 = Resources.Load<Sprite>("Textures/001-mainmenu/b_language_en2");
        frSprite1 = Resources.Load<Sprite>("Textures/001-mainmenu/b_language_fr1");
        frSprite2 = Resources.Load<Sprite>("Textures/001-mainmenu/b_language_fr2");
        scnSprite1 = Resources.Load<Sprite>("Textures/001-mainmenu/b_language_cn1");
        scnSprite2 = Resources.Load<Sprite>("Textures/001-mainmenu/b_language_cn2");
        unscnSprite1 = Resources.Load<Sprite>("Textures/001-mainmenu/b_language_cnt1");
        unscnSprite2 = Resources.Load<Sprite>("Textures/001-mainmenu/b_language_cnt2");

        ENIcon = transform.Find("ENButton").GetComponent<Image>();
        ENButton = transform.Find("ENButton").GetComponent<Button>();
        ENButton.onClick.AddListener(ENButtonClick);

        FRIcon = transform.Find("FRButton").GetComponent<Image>();
        FRButton = transform.Find("FRButton").GetComponent<Button>();
        FRButton.onClick.AddListener(FRButtonClick);

        SCNIcon = transform.Find("SCNButton").GetComponent<Image>();
        SCNButton = transform.Find("SCNButton").GetComponent<Button>();
        SCNButton.onClick.AddListener(SCNButtonClick);

        UNSCNIcon = transform.Find("UNSCNButton").GetComponent<Image>();
        UNSCNButton = transform.Find("UNSCNButton").GetComponent<Button>();
        UNSCNButton.onClick.AddListener(UNSCNButtonClick);
    }

    public void ShowPanel()
    {
        gameObject.SetActive(true);
    }

    public void HidePanel()
    {
        gameObject.SetActive(false);
    }

    void ENButtonClick()
    {
        DisableButton();
        currentLanguageSprite = ENIcon.sprite = enSprite1;
    }

    void FRButtonClick()
    {
        DisableButton();
        currentLanguageSprite = FRIcon.sprite = frSprite1;
    }

    void SCNButtonClick()
    {
        DisableButton();
        currentLanguageSprite = SCNIcon.sprite = scnSprite1;
    }

    void UNSCNButtonClick()
    {
        DisableButton();
        currentLanguageSprite = UNSCNIcon.sprite = unscnSprite1;
    }

    void DisableButton()
    {
        ENIcon.sprite = enSprite2;
        FRIcon.sprite = frSprite2;
        SCNIcon.sprite = scnSprite2;
        UNSCNIcon.sprite = unscnSprite2;
    }
}