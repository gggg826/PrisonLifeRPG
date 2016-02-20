/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;

public class CharactorView : UnitySingletonG<CharactorView>
{
    public void RenderRole(CharactorModel model, Transform parent)
    {
        GameObject go = (GameObject)Instantiate(Resources.Load("Prefabs/" + model.bodyModel.prefabKind));
        go.name = model.roleName;
        go.transform.SetParent(parent);
        go.transform.localPosition = Vector3.zero;
        CharactorItem item = go.GetComponent<CharactorItem>();
        item.InitCharactorUI(model.roleName, model);
    }
}