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
        animation.Stop();
    }

    /// <summary>
    /// 加载图片并赋值给Prefab
    /// </summary>
    /// <param name="_name">角色名称</param>
    /// <param name="model"></param>
    protected void InitSpriteShow(CharactorModel _model)
    {
        CharactorModel model = _model;
        roleName.text = model.roleName;
        head.overrideSprite = Resources.Load<Sprite>("Textures/Charactors/" + model.bodyModel.headICONName);
        body.overrideSprite = Resources.Load<Sprite>("Textures/Charactors/" + model.bodyModel.normalBodyName);
        rleg.overrideSprite = Resources.Load<Sprite>("Textures/Charactors/" + model.bodyModel.normalLegName);
        lleg.overrideSprite = Resources.Load<Sprite>("Textures/Charactors/" + model.bodyModel.normalLegName);
        rhand.overrideSprite = Resources.Load<Sprite>("Textures/Charactors/" + model.bodyModel.normalHandName);
        lhand.overrideSprite = Resources.Load<Sprite>("Textures/Charactors/" + model.bodyModel.normalHandName);
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

    protected IEnumerator BeginTween(string status)
    {
        yield return new WaitForSeconds(Random.Range(0, 300)/100f);
        animation.Play(status);
    }
    
    IEnumerator Turn()
    {
        yield return new WaitForSeconds(Random.Range(0, 200) / 100f);
        head.transform.localScale = new Vector3(-head.transform.localScale.x, head.transform.localScale.y, head.transform.localScale.z);
        body.transform.localScale = new Vector3(-body.transform.localScale.x, body.transform.localScale.y, body.transform.localScale.z);
    }

    IEnumerator Idle()
    {
        yield return new WaitForSeconds(Random.Range(200, 500) / 100f);
        animation.Play();
    }
}