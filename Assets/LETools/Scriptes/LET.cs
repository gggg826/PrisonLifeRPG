﻿/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using System.Collections.Generic;

public class LET : MonoBehaviour 
{
    
    static public void ReSortStringList(List<string> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            string temp = list[i];
            int index = Random.Range(0, list.Count);
            list[i] = list[index];
            list[index] = temp;
        }
    }
    
    
    
    
    
    // static private Dictionary<string, Sprite> spriteDic = new Dictionary<string, Sprite>();
    // static private Dictionary<string, string> bundleNameDic = new Dictionary<string, string>();
    // static private AssetBundle SpriteBundle;
    // /// <summary>
    // /// 从bundle加载图片资源
    // /// </summary>
    // /// <param name="fileName">XX.assetbundle</param>
    // /// <param name="spriteName">图片名称</param>
    // /// <returns>Sprite</returns>
    // static public Sprite LoadSprite(string fileName, string spriteName)
    // {
    //     // if(!bundleNameDic.ContainsKey(fileName))

    //     if(spriteDic.ContainsKey(spriteName))
    //     {
    //         Sprite sprite;
    //         spriteDic.TryGetValue(spriteName, out sprite);
    //         return sprite;
    //     }
    //     else
    //     {
    //         if(SpriteBundle == null)
    //             SpriteBundle = AssetBundle.CreateFromFile(Application.streamingAssetsPath + "/Sprites/" + fileName + ".assetbundle");
    //         Sprite sprite = SpriteBundle.LoadAsset<Sprite>(spriteName);
    //         spriteDic.Add(spriteName, sprite);
    //         SpriteBundle.Unload(false);
    //         return sprite;
    //     }
    // }
}