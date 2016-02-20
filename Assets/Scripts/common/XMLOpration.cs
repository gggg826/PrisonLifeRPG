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
    static public Dictionary<string, string[]> GetRolesInfoDictionary(string path)
    {
        if (!File.Exists(path))
        {
            Debug.LogError(path + "is not found!");
            return null;
        }

        Dictionary<string, string[]> roleInfoDic = new Dictionary<string, string[]>();

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

            // print(name + "  " + headNo + "  " + bodyType + "  " + skinColor + "  " + prefabKind);

            roleInfoDic.Add(name, new string[]{ headNo, bodyType, skinColor, prefabKind });
        }
        return roleInfoDic;
    }
}