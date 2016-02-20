/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using System.Collections.Generic;
using System.Xml;
using System.IO;

public class XMLOpration
{
    static public Dictionary<string, CharactorModel> GetRolesInfoDictionary(string path)
    {
        if (!File.Exists(path))
        {
            Debug.LogError(path + "is not found!");
            return null;
        }

        Dictionary<string, CharactorModel> rolesInfoDic = new Dictionary<string, CharactorModel>();

        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load(path);
        XmlNodeList node = xmlDoc.SelectSingleNode("Root").ChildNodes;
        
        foreach (XmlElement roleInfo in node)
        {
            string name = roleInfo.GetAttribute("Name");
            string headNo = roleInfo.GetAttribute("HeadNO");
            string bodyType = roleInfo.GetAttribute("BodyType");
            string skinColor = roleInfo.GetAttribute("SkinColor");
            string prefabKind = roleInfo.GetAttribute("PrefabKind");

            CharactorModel model = new CharactorModel(new string[] {name, headNo, bodyType, skinColor, prefabKind });
            // print(name + "  " + headNo + "  " + bodyType + "  " + skinColor + "  " + prefabKind);

            rolesInfoDic.Add(name, model);
        }
        return rolesInfoDic;
    }
}