/*****************************
*
*  Author : TheNO.5
*
******************************/

//prisonChar_bodyNaked3_g

using UnityEngine;

public class CharactorModel
{
    public string roleName;
    public BodyModel bodyModel;
    public ROLESTATUS status;
    public int power;
    public int agility;
    public int intelligence;
    public int charisma;
    public int luck;
    public int prisonDays;
    public string prisonGol;
    public string[] skillList;
    public string traitICON;

    /// <summary>
    /// XML加载方式
    /// </summary>
    /// <param name="_info"></param>
    public CharactorModel(string[] _info)
    {
        roleName = _info[0];
        status = ROLESTATUS.Normal;
        bodyModel = new BodyModel(new string[] { _info[1], _info[2], _info[3], _info[4] }, status);
    }


    /// <summary>
    /// Database加载方式
    /// </summary>
    /// <param name="name"></param>
    public CharactorModel(string tableName, string name, ROLESTATUS _status)
    {
        roleName = name;
        status = _status;
        bodyModel = new BodyModel(new string[]
        {
            DATAManager.GetTextDBValue(tableName, "HeadNo", name),
            DATAManager.GetTextDBValue(tableName, "BodyType",name),
            DATAManager.GetTextDBValue(tableName, "SkinColor", name),
            DATAManager.GetTextDBValue(tableName, "PrefabKind", name)
        }, status);
        InitProperty(tableName, name);
    }
    public CharactorModel(string tableName, int rowID, ROLESTATUS _status)
    {
        string[] info = DATAManager.GetSingleCharactorInfo(tableName,rowID);
        roleName = info[0];
        bodyModel = new BodyModel(new string[] { info[1], info[2], info[3], info[4] }, _status);
        InitProperty(tableName, roleName);
    }
    
    void InitProperty(string tableName, string name)
    {
        power = DATAManager.GetIntegerDBValue(tableName, "Power", name);
        agility = DATAManager.GetIntegerDBValue(tableName, "Agility", name);
        intelligence = DATAManager.GetIntegerDBValue(tableName, "Intelligence", name);
        charisma = DATAManager.GetIntegerDBValue(tableName, "Charm", name);
        luck = DATAManager.GetIntegerDBValue(tableName, "Luck", name);
        prisonDays = DATAManager.GetIntegerDBValue(tableName, "PrisonDays", name);
        prisonGol = DATAManager.GetTextDBValue(tableName, "PrisonGol", name);
        skillList = GetSkillList(tableName, name);
        traitICON = DATAManager.GetTextDBValue(tableName, "Trait", name);
    }

    string[] GetSkillList(string tableName, string name)
    {
        string[] list = DATAManager.GetTextDBValue(tableName, "SkillList", name).Split(',');
        return list;
    }

    public void SetRoleStatus(ROLESTATUS _status)
    {
        status = _status;
    }
}