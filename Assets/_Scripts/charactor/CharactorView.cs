/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;

public class CharactorView : UnitySingletonG<CharactorView>
{
    /// <summary>
    /// 渲染单个角色
    /// </summary>
    /// <param name="model"></param>
    /// <param name="parent"></param>
    public void RenderRole(CharactorModel model, Transform parent, int scene)
    {
        GameObject go = (GameObject)Instantiate(Resources.Load("Prefabs/" + model.bodyModel.prefabKind));
        go.name = model.roleName;
        go.transform.SetParent(parent);
        go.transform.localPosition = Vector3.zero;
        go.transform.localScale = Vector3.one;
        CharactorItem item = go.GetComponent<CharactorItem>();
        item.InitCharactorItem(model, scene);
    }

    /// <summary>
    /// 渲染第一界面带牌小人
    /// </summary>
    /// <param name="model"></param>
    /// <param name="sprite">牌图片</param>
    /// <param name="parent"></param>
    public void RenderButtonBord(CharactorModel model, Sprite sprite, Transform parent)
    {
        GameObject go = (GameObject)Instantiate(Resources.Load("Prefabs/ButtonBord"));
        go.transform.SetParent(parent);
        go.transform.localPosition = Vector3.zero;
        go.transform.localScale = Vector3.one;
        CharactorBordItem item = go.GetComponent<CharactorBordItem>();
        item.InitBordItem(model, sprite);
    }

    public void AddHeadIcon(string roleName, Transform parent)
    {
        string headNO = DATAManager.GetTextDBValue("RoleInfo", "HeadNO", roleName);
        GameObject go = (GameObject)Instantiate(Resources.Load("Prefabs/HeadIcon"));
        go.transform.SetParent(parent);
        go.transform.localScale = Vector3.one;
        HeadIconItem item = go.GetComponent<HeadIconItem>();
        print(headNO);
        item.Init("prisonChar_head" + headNO);
    }
}