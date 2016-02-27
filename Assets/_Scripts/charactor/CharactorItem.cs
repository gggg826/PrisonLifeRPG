/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CharactorItem : MonoBehaviour
{
    private Text roleName;
    private Image rleg;
    private Image lleg;
    private Image body;
    private Image rhand;
    private Image lhand;
    private Image head;
    private Animation animation;

    void Awake()
    {
        roleName = transform.Find("Name").GetComponent<Text>();
        rleg = transform.Find("RLeg").GetComponent<Image>();
        lleg = transform.Find("LLeg").GetComponent<Image>();
        body = transform.Find("Body").GetComponent<Image>();
        rhand = transform.Find("RHand").GetComponent<Image>();
        lhand = transform.Find("LHand").GetComponent<Image>();
        head = transform.Find("Head").GetComponent<Image>();
        animation = GetComponent<Animation>();
    }
    
    void LoopIdle()
    {
        StartCoroutine(Idle());
    }
    
    void TurnOver()
    {
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
    }
    
    IEnumerator Idle()
    {
        yield return new WaitForSeconds(Random.Range(1,3));
        animation.Play("Idle");
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