/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using UnityEngine.UI;

public class HeadIconItem : MonoBehaviour 
{
    public Image bg;
    public Image sprite;
    
    void Awake()
    {
        bg = GetComponent<Image>();
        sprite = transform.Find("Image").GetComponent<Image>();
    }
    
    public void Init(string headIcon)
    {
        bg.sprite = TexturesManager.CharactorsBundle.LoadAsset<Sprite>("photoBG");
        sprite.sprite = TexturesManager.CharactorsBundle.LoadAsset<Sprite>(headIcon);
    }
}