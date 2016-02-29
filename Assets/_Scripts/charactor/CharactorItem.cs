/*****************************
*
*  Author : TheNO.5
*
******************************/


public class CharactorItem : BaseChractorItem
{
    void Awake()
    {
        base.LoadSprite();
    }
    
    void Start()
    {
        StartCoroutine(base.BeginTween("Idle"));
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