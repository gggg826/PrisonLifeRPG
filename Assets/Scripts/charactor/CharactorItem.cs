/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using UnityEngine.UI;

public class CharactorItem : MonoBehaviour
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

    public void InitCharactorUI(string _name, CharactorModel model)
    {
        roleName.text = _name;
        head.overrideSprite = Resources.Load<Sprite>(model.bodyModel.headName);
        body.overrideSprite = Resources.Load<Sprite>(model.bodyModel.normalBodyName);
        rleg.overrideSprite = Resources.Load<Sprite>(model.bodyModel.normalLegName);
        lleg.overrideSprite = Resources.Load<Sprite>(model.bodyModel.normalLegName);
        rhand.overrideSprite = Resources.Load<Sprite>(model.bodyModel.normalHandName);
        lhand.overrideSprite = Resources.Load<Sprite>(model.bodyModel.normalHandName);
    }
}