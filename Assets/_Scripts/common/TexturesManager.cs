/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;

public class TexturesManager
{
    static private AssetBundle _charactorsBundle;
    static public AssetBundle CharactorsBundle
    {
        get
        {
            if(_charactorsBundle == null)
                _charactorsBundle = AssetBundle.CreateFromFile(Application.streamingAssetsPath + "/Sprites/Charactors.assetbundle");
            return _charactorsBundle;
        }
    }
    
     static private AssetBundle _icon;
    static public AssetBundle IconBundle
    {
        get
        {
            if(_icon == null)
                _icon = AssetBundle.CreateFromFile(Application.streamingAssetsPath + "/Sprites/ICON.assetbundle");
            return _icon;
        }
    }
}