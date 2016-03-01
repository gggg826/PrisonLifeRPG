/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine.UI;

public class CharactorItem : BaseChractorItem
{
    public Button button;
    void Awake()
    {
        base.LoadSprite();
        button = GetComponent<Button>();
    }
    
    void Start()
    {
        StartCoroutine(base.BeginTween("Idle"));
        button.onClick.AddListener(delegate { CharactorsController.Instance.SendMessage("ShowRoleInfoPanel", name); });
    }
    
    /// <summary>
    /// 初始化Prefab
    /// </summary>
    /// <param name="name"></param>
    /// <param name="model"></param>
    public void InitCharactorItem(string name, CharactorModel model)
    {
        base.InitSpriteShow(name, model);
    }
}