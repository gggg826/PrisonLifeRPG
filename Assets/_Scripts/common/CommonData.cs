/*****************************
*
*  Author : TheNO.5
*
******************************/

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum LOADDATETYPE
{
    XMLFILE,
    SQLiteDB
}

public enum PREFABKIND
{
    Body_up,
    Leg_up
}

public enum ROLESTATUS
{
    Normal,
    Naked
}

public static class CommonDATA
{
    static private LOADDATETYPE _loadType = LOADDATETYPE.XMLFILE;
    static public LOADDATETYPE LoadType { get { return _loadType; } set { _loadType = value; } }

    static private Dictionary<string, CharactorModel> _rolesInfo = XMLOpration.GetRolesInfoDictionary(Application.streamingAssetsPath + "/RoleInfo.xml");
    static public Dictionary<string, CharactorModel> RolseInfo { get { return _rolesInfo; } }


    static private string _xmlPath = Application.streamingAssetsPath + "/RoleInfo.xml";
    static public string XmlPath { get { return _xmlPath; } }


    static private string _dBPath = Application.streamingAssetsPath + "/RoleDatabase.db";
    static public string DBPath { get { return _dBPath; } }


    /// <summary>
    /// 从数据表中获取指定字段值
    /// </summary>
    /// <param name="tableName"></param>
    /// <param name="key"></param>
    /// <param name="name"></param>
    /// <returns>string</returns>
    static public string GetDBValue(string tableName, string key, string name)
    {
        SQLiteOpration data = new SQLiteOpration(CommonDATA.DBPath);
        string value = data.GetValueByKey(tableName, key, name);
        data.CloseConnection();
        return value;
    }


    /// <summary>
    /// 从数据表中获取指定列所有字段值
    /// </summary>
    /// <param name="tableName"></param>
    /// <param name="key"></param>
    /// <returns>返回ArrayList</returns>
    static public ArrayList GetAllRoleName(string tableName)
    {
        ArrayList temp = new ArrayList();
        SQLiteOpration data = new SQLiteOpration(CommonDATA.DBPath);
        temp = data.GetSelectColALL("RoleInfo", "Name");
        data.CloseConnection();
        return temp;
    }
}