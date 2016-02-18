/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;
using UnityEngine.UI;

public class CharactorUI : MonoBehaviour
{
    private Image rleg;
    private Image lleg;
    private Image body;
    private Image rhand;
    private Image lhand;
    private Image head;

	void Awake()
    {
        rleg = transform.Find("RLeg").GetComponent<Image>();
        lleg = transform.Find("LLeg").GetComponent<Image>();
        body = transform.Find("Body").GetComponent<Image>();
        rhand = transform.Find("RHand").GetComponent<Image>();
        lhand = transform.Find("LHand").GetComponent<Image>();
        head = transform.Find("Head").GetComponent<Image>();
    }

    public void InitCharactorUI(string _head)
    {
        head.overrideSprite = Resources.Load<Sprite>("Textures/Charactors/" + _head);
    }
}