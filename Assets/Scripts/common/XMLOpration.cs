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
    /// <summary>
    /// 从XML读取数据
    /// </summary>
    /// <param name="path">XML路径</param>
    /// <returns>返回Dictionary</returns>
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

            CharactorModel model = new CharactorModel(new string[] { name, headNo, bodyType, skinColor, prefabKind });
            // print(name + "  " + headNo + "  " + bodyType + "  " + skinColor + "  " + prefabKind);

            rolesInfoDic.Add(name, model);
        }
        return rolesInfoDic;
    }

    /// <summary>
    /// XML转SQLiteDatabase
    /// </summary>
    /// <param name="xmlPath">xml路径</param>
    /// <param name="sqlLitePath">SQLite数据库路径</param>
    static public void XMLToSQLiteDatabase(string xmlPath, string sqlLitePath)
    {
        SQLiteOpration data = new SQLiteOpration(sqlLitePath);

        try
        {
            data.CreateTable("RoleInfo",
                                     new string[] { "Name", "HeadNO", "BodyType", "SkinColor", "PrefabKind" },
                                     new string[] { "Text", "Text", "Text", "Text ", "Text" });
        }
        catch (System.Exception)
        {
            data.CloseConnection();
            return;
        }

        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load(xmlPath);
        XmlNodeList node = xmlDoc.SelectSingleNode("Root").ChildNodes;

        foreach (XmlElement roleInfo in node)
        {
            string name = roleInfo.GetAttribute("Name");
            string headNo = roleInfo.GetAttribute("HeadNO");
            string bodyType = roleInfo.GetAttribute("BodyType");
            string skinColor = roleInfo.GetAttribute("SkinColor");
            string prefabKind = roleInfo.GetAttribute("PrefabKind");

            data.InsertInto("RoleInfo", 
                            new string[] { "'"+name+ "'", "'" + headNo+ "'", "'" + bodyType+ "'",
                            "'" + skinColor+ "'", "'" + prefabKind+ "'" });
        }
        data.CloseConnection();
    }
}