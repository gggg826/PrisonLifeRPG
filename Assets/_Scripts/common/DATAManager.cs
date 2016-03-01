﻿/*****************************
*
*  Author : TheNO.5
*
******************************/

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Mono.Data.Sqlite;

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

public static class DATAManager
{
    static private LOADDATETYPE _loadType = LOADDATETYPE.XMLFILE;
    static public LOADDATETYPE LoadType { get { return _loadType; } set { _loadType = value; } }

    static private Dictionary<string, CharactorModel> _rolesInfo = XMLOpration.GetRolesInfoDictionary(Application.streamingAssetsPath + "/RoleInfo.xml");
    static public Dictionary<string, CharactorModel> RolseInfo { get { return _rolesInfo; } }


    static private string _xmlPath = Application.streamingAssetsPath + "/RoleInfo.xml";
    static public string XmlPath { get { return _xmlPath; } }


    static private string _dBPath = Application.streamingAssetsPath + "/GameDatabase.db";
    static public string DBPath { get { return _dBPath; } }

    static private int _gotCountAchievements = 0;
    static public int GOTCOUNTACHIEVEMENTS { get { return _gotCountAchievements; }set { _gotCountAchievements = value; } }


    /// <summary>
    /// 从数据表中获取指定字段值
    /// </summary>
    /// <param name="tableName"></param>
    /// <param name="key"></param>
    /// <param name="name"></param>
    /// <returns>string</returns>
    static public string GetDBValue(string tableName, string key, string name)
    {
        SQLiteConnect data = new SQLiteConnect(DATAManager.DBPath);
        SqliteDataReader reader = data.SelectValueByKey(tableName, key, name);
        string value = null;
        while (reader.Read())
        {
            value = reader.GetString(reader.GetOrdinal(key));
        }
        data.CloseConnection();
        return value;
    }

    /// <summary>
    /// 根据ROWID获取一行人物信息
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    static public string[] GetSingleCharactorInfo(int id)
    {
        SQLiteConnect data = new SQLiteConnect(DATAManager.DBPath);
        SqliteDataReader reader = data.GetSingleRow("RoleInfo", id);
        string[] info = new string[5];
        while (reader.Read())
        {
            info[0] = reader.GetString(reader.GetOrdinal("Name"));
            info[1] = reader.GetString(reader.GetOrdinal("HeadNO"));
            info[2] = reader.GetString(reader.GetOrdinal("BodyType"));
            info[3] = reader.GetString(reader.GetOrdinal("SkinColor"));
            info[4] = reader.GetString(reader.GetOrdinal("PrefabKind"));
        }
        data.CloseConnection();
        return info;
    }

    /// <summary>
    /// 从数据表中获取指定列所有字段值
    /// </summary>
    /// <param name="tableName"></param>
    /// <param name="key"></param>
    /// <returns>返回ArrayList</returns>
    static public ArrayList GetAllRoleName()
    {
        ArrayList temp = new ArrayList();
        SQLiteConnect data = new SQLiteConnect(DATAManager.DBPath);
        temp = data.SelectColALL("RoleInfo", "Name");
        data.CloseConnection();
        return temp;
    }

    /// <summary>
    /// 从数据表中获取某一成就所有字段值
    /// </summary>
    /// <param name="key">字段名称</param>
    /// <param name="value">字段值</param>
    /// <returns></returns>
    static public string[] GetSingleAchievementInfo(string key, string value)
    {
        SQLiteConnect data = new SQLiteConnect(DATAManager.DBPath);
        SqliteDataReader reader = data.GetSingleRow("Achievements", key, value);
        string[] info = new string[4];
        while (reader.Read())
        {
            info[0] = reader.GetString(reader.GetOrdinal("Name"));
            info[1] = reader.GetString(reader.GetOrdinal("ICON"));
            info[2] = reader.GetString(reader.GetOrdinal("Status"));
            info[3] = reader.GetString(reader.GetOrdinal("Description"));
        }
        data.CloseConnection();
        return info;
    }

    /// <summary>
    /// 从数据表中获取指定成就所有字段值
    /// </summary>
    /// <param name="id">ROWID</param>
    /// <returns></returns>
    static public string[] GetSingleAchievementInfo(int id)
    {
        SQLiteConnect data = new SQLiteConnect(DATAManager.DBPath);
        SqliteDataReader reader = data.GetSingleRow("Achievements", id);
        string[] info = new string[4];
        while (reader.Read())
        {
            info[0] = reader.GetString(reader.GetOrdinal("Name"));
            info[1] = reader.GetString(reader.GetOrdinal("ICON"));
            info[2] = reader.GetString(reader.GetOrdinal("Status"));
            info[3] = reader.GetString(reader.GetOrdinal("Description"));
        }
        data.CloseConnection();
        return info;
    }
}