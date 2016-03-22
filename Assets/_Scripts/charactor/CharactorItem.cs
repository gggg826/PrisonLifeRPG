/*****************************
*
*  Author : TheNO.5
*
******************************/

using UnityEngine;
using UnityEngine.UI;

public class CharactorItem : BaseChractorItem
{
    private Button button;
    private Transform circle;
    private Transform arrow;

    void Awake()
    {
        base.LoadSprite();
        button = GetComponent<Button>();
        circle = transform.Find("Circle").transform;
        arrow = transform.Find("Arrow").transform;
    }

    void Start()
    {
        StartCoroutine(base.BeginTween("Idle"));
    }

    /// <summary>
    /// 初始化Prefab
    /// </summary>
    /// <param name="name"></param>
    /// <param name="_model"></param>
    public void InitCharactorItem(CharactorModel _model, int scene)
    {
        base.InitSpriteShow(_model);
        print(_model.isPlayer);
        print(DATAManager.PLAYER.isPlayer);
        // if(_model.isPlayer == 1)
        // {
        //     circle.GetComponent<Image>().sprite = TexturesManager.CharactorsBundle.LoadAsset<Sprite>("b_walk_b");
        //     arrow.GetComponent<Image>().sprite = TexturesManager.CharactorsBundle.LoadAsset<Sprite>("b_arrow_b");
        // }
        // else
        HideCircle();
        if (scene == 0)
            button.onClick.AddListener(delegate { ButtonClick(_model); });
    }

    public void InitPlayerItem(CharactorModel _model)
    {
        base.InitSpriteShow(_model);
        print(_model.isPlayer);
        print(DATAManager.PLAYER.isPlayer);
        circle.GetComponent<Image>().sprite = TexturesManager.CharactorsBundle.LoadAsset<Sprite>("b_walk_b");
        arrow.GetComponent<Image>().sprite = TexturesManager.CharactorsBundle.LoadAsset<Sprite>("b_arrow_b");
    }

    void ButtonClick(CharactorModel _model)
    {
        ShowCircle();
        CharactorsController.Instance.ShowRoleInfoPanel(_model, this);
    }

    public void HideCircle()
    {
        circle.gameObject.SetActive(false);
        arrow.gameObject.SetActive(false);
    }

    public void ShowCircle()
    {
        circle.gameObject.SetActive(true);
        arrow.gameObject.SetActive(true);
    }
}