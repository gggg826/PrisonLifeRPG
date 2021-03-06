﻿/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using UnityEngine.UI;

public class BGUI : MonoBehaviour 
{
    public Button shareButton;
    public Button languageSeletButton;
    public Image languageSeletIcon;

    void Awake () 
    {
	   shareButton = transform.parent.Find("BG/ShareButton").GetComponent<Button>();
       shareButton.onClick.AddListener(delegate {ButtonManager.Instance.SendMessage("ShareButtonClick");});
       
       languageSeletButton = transform.parent.Find("BG/LanguageButton").GetComponent<Button>();
       languageSeletButton.onClick.AddListener(delegate {ButtonManager.Instance.SendMessage("LanguageButtonClick");});
       
       languageSeletIcon = transform.parent.Find("BG/LanguageButton").GetComponent<Image>();
    }
    
    public Sprite GetlanguageCurrentSprite()
    {
        Debug.Log(languageSeletIcon.sprite.name);
        // return languageSeletButton.gameObject.GetComponent<Image>().sprite;
        return languageSeletIcon.sprite;
    }
    
    void LanguageButtonIconShow(Sprite currentSprite)
    {
        languageSeletIcon.overrideSprite = currentSprite;
    }
}