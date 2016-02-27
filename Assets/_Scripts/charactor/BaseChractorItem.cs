/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BaseChractorItem : MonoBehaviour
{
    protected Text roleName;
    protected Image rleg;
    protected Image lleg;
    protected Image body;
    protected Image rhand;
    protected Image lhand;
    protected Image head;
    protected Animation animation;

    /// <summary>
    /// 初始化变量
    /// </summary>
    protected void LoadSprite()
    {
        roleName = transform.Find("Name").GetComponent<Text>();
        rleg = transform.Find("RLeg").GetComponent<Image>();
        lleg = transform.Find("LLeg").GetComponent<Image>();
        body = transform.Find("Body/Body").GetComponent<Image>();
        rhand = transform.Find("Body/RHand").GetComponent<Image>();
        lhand = transform.Find("Body/LHand").GetComponent<Image>();
        head = transform.Find("Head").GetComponent<Image>();
        animation = GetComponent<Animation>();
    }

    /// <summary>
    /// 加载图片并赋值给Prefab
    /// </summary>
    /// <param name="_name">角色名称</param>
    /// <param name="model"></param>
    protected void InitSpriteShow(string _name, CharactorModel model)
    {
        roleName.text = _name;
        head.overrideSprite = Resources.Load<Sprite>(model.bodyModel.headName);
        body.overrideSprite = Resources.Load<Sprite>(model.bodyModel.normalBodyName);
        rleg.overrideSprite = Resources.Load<Sprite>(model.bodyModel.normalLegName);
        lleg.overrideSprite = Resources.Load<Sprite>(model.bodyModel.normalLegName);
        rhand.overrideSprite = Resources.Load<Sprite>(model.bodyModel.normalHandName);
        lhand.overrideSprite = Resources.Load<Sprite>(model.bodyModel.normalHandName);
    }

    /// <summary>
    /// 动画事件-循环Idle
    /// </summary>
    void LoopIdle()
    {
        StartCoroutine(Idle());
    }

    /// <summary>
    /// 动画事件-变换左右朝向
    /// </summary>
    void TurnOver()
    {
        StartCoroutine(Turn());
    }

    IEnumerator Turn()
    {
        yield return new WaitForSeconds(Random.Range(0, 200) / 100f);
        head.transform.localScale = new Vector3(-head.transform.localScale.x, head.transform.localScale.y, head.transform.localScale.z);
        body.transform.localScale = new Vector3(-body.transform.localScale.x, body.transform.localScale.y, body.transform.localScale.z);
    }

    IEnumerator Idle()
    {
        yield return new WaitForSeconds(Random.Range(200, 400) / 100f);
        animation.Play();
    }
}