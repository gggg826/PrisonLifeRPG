/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using UnityEngine.UI;

public class CharactorUI : MonoBehaviour
{
    private Text roleName;
    private Image rleg;
    private Image lleg;
    private Image body;
    private Image rhand;
    private Image lhand;
    private Image head;

    void Awake()
    {
        roleName = transform.Find("Name").GetComponent<Text>();
        rleg = transform.Find("RLeg").GetComponent<Image>();
        lleg = transform.Find("LLeg").GetComponent<Image>();
        body = transform.Find("Body").GetComponent<Image>();
        rhand = transform.Find("RHand").GetComponent<Image>();
        lhand = transform.Find("LHand").GetComponent<Image>();
        head = transform.Find("Head").GetComponent<Image>();
    }


    //suf后缀  pre前缀
    const string preHeadName = "prisonChar_head";
    const string preNormalBodyName = "prisonChar_body";
    const string preNormalHandName = "prisonChar_hand";
    const string preNormalLegName = "prisonChar_leg";
    private string[] info;
    public void InitCharactorUI(string _name, string[] _info)
    {
        info = _info;
        
        roleName.text = _name;
        head.overrideSprite = Resources.Load<Sprite>(GetSpriteName(preHeadName));
        body.overrideSprite = Resources.Load<Sprite>(GetSpriteName(preNormalBodyName));
        rleg.overrideSprite = Resources.Load<Sprite>(GetSpriteName(preNormalLegName));
        lleg.overrideSprite = Resources.Load<Sprite>(GetSpriteName(preNormalLegName));
        rhand.overrideSprite = Resources.Load<Sprite>(GetSpriteName(preNormalHandName));
        lhand.overrideSprite = Resources.Load<Sprite>(GetSpriteName(preNormalHandName));
    }

    // 图片名字 = 前缀 + 体型+肤色
    // { headNo, bodyType, skinColor, prefabKind }
    string GetSpriteName(string preName)
    {
        if (preName == preHeadName)
        {
            if (!Resources.Load<Sprite>("Textures/Charactors/" + preHeadName + info[0]))
            {
                Debug.LogError("Resources " + preHeadName + info[0] + " not found.");
                return null;
            }
            return ("Textures/Charactors/" + preHeadName + info[0]);
        }
        else
        // return ("Textures/Charactors/" + preName + info[1] + info[2]);
        {
            if (!Resources.Load<Sprite>("Textures/Charactors/" + preName + info[1] + info[2]))
            {
                Debug.LogError("Resources " + preName + info[1] + info[2] + " not found.");
                return null;
            }
            return ("Textures/Charactors/" + preName + info[1] + info[2]);
        }
    }
}