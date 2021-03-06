﻿/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;

public class BodyModel
{
    public string headICONName;
    public string normalBodyName;
    public string normalHandName;
    public string normalLegName;
    public string prefabKind;
    public ROLESTATUS status;

    //suf后缀  pre前缀
    const string preHeadName = "prisonChar_head";
    const string preNormalBodyName = "prisonChar_body";
    const string preNormalHandName = "prisonChar_hand";
    const string preNormalLegName = "prisonChar_leg";

    private string[] info;

    public BodyModel(string[] _info, ROLESTATUS _status)
    {
        info = _info;
        status = _status;

        headICONName = GetSpriteName(preHeadName);
        normalBodyName = GetSpriteName(preNormalBodyName);
        normalHandName = GetSpriteName(preNormalHandName);
        normalLegName = GetSpriteName(preNormalLegName);
        prefabKind = GetPrefabKind();
    }

    // { headNo, bodyType, skinColor, prefabKind }
    string GetSpriteName(string preName)
    {
        if (preName == preHeadName)
        {
            //if (!Resources.Load<Sprite>("Textures/Charactors/" + preHeadName + info[0]))
            if (!TexturesManager.CharactorsBundle.LoadAsset<Sprite>(preHeadName + info[0]))
            {
                Debug.LogError("AbundleResources " + preHeadName + info[0] + " not found.");
                return null;
            }
            return (preHeadName + info[0]);
        }

        else if(preName == preNormalLegName && status == ROLESTATUS.Normal)
        {
            if (!TexturesManager.CharactorsBundle.LoadAsset<Sprite>(preName + info[1]))
            {
                Debug.LogError("AbundleResources " + preName + info[1] + " not found.");
                return null;
            }
            return (preName + info[1]);
        }
        else
        {
            //  prisonChar_bodyNaked3_g
            // 图片名字 = 前缀 + 状态 + 体型 +肤色
            string strStatus;
            if (status == ROLESTATUS.Normal)
                strStatus = "";
            else
                strStatus = status.ToString();
            //if (!Resources.Load<Sprite>("Textures/Charactors/" + preName + strStatus + info[1] + info[2]))
            if (!TexturesManager.CharactorsBundle.LoadAsset<Sprite>(preName + strStatus + info[1] + info[2]))
            {
                Debug.LogError("AbundleResources " + preName + strStatus + info[1] + info[2] + " not found.");
                return null;
            }
            return (preName + strStatus + info[1] + info[2]);
        }
    }

    string GetPrefabKind()
    {
        if (status == ROLESTATUS.Naked)
            return PREFABKIND.Body_up.ToString();
        else
            return info[3];
    }
}