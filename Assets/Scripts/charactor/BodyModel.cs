/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;

public class BodyModel
{
    public string headName;
    public string normalBodyName;
    public string normalHandName;
    public string normalLegName;
    public string prefabKind;

    //suf后缀  pre前缀
    const string preHeadName = "prisonChar_head";
    const string preNormalBodyName = "prisonChar_body";
    const string preNormalHandName = "prisonChar_hand";
    const string preNormalLegName = "prisonChar_leg";

    private string[] info;

    public BodyModel(string[] _info)
    {
        info = _info;
        headName = GetSpriteName(preHeadName);
        normalBodyName = GetSpriteName(preNormalBodyName);
        normalHandName = GetSpriteName(preNormalHandName);
        normalLegName = GetSpriteName(preNormalLegName);
        prefabKind = GetPrefabKind();
    }


    // 图片名字 = 前缀 + 体型+肤色
    // { headNo, bodyType, skinColor, prefabKind }
    string GetSpriteName(string preName)
    {
        if (preName == preHeadName)
        {
            if (!Resources.Load<Sprite>("Textures/Charactors/" + preHeadName + info[0]))
            {
                Debug.LogError("Resources " + preHeadName + info[0] + " not found.");
                return null;
            }
            return ("Textures/Charactors/" + preHeadName + info[0]);
        }
        else
        {
            if (!Resources.Load<Sprite>("Textures/Charactors/" + preName + info[1] + info[2]))
            {
                Debug.LogError("Resources " + preName + info[1] + info[2] + " not found.");
                return null;
            }
            return ("Textures/Charactors/" + preName + info[1] + info[2]);
        }
    }

    string GetPrefabKind()
    {
        string temp;
        if (info[3] == CommonDATA.PREFABKIND.Leg_up.ToString())
            temp = CommonDATA.PREFABKIND.Leg_up.ToString();
        else
            temp = CommonDATA.PREFABKIND.Body_up.ToString();
        return temp;
    }
}