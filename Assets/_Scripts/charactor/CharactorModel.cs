/*****************************
*
*  Author : TheNO.5
*
******************************/

//prisonChar_bodyNaked3_g


public class CharactorModel
{
    public string roleName;
    public BodyModel bodyModel;
    public ROLESTATUS status;

    /// <summary>
    /// XML加载方式
    /// </summary>
    /// <param name="_info"></param>
    public CharactorModel(string[] _info)
    {
        roleName = _info[0];
        status = ROLESTATUS.Normal;
        bodyModel = new BodyModel(new string[] { _info[1], _info[2], _info[3], _info[4]}, status);
    }


    /// <summary>
    /// Database加载方式
    /// </summary>
    /// <param name="name"></param>
    public CharactorModel(string name, ROLESTATUS _status)
    {
        roleName = name;
        status = _status;
        bodyModel = new BodyModel(new string[] 
        {
            DATAManager.GetDBValue("RoleInfo", "HeadNo", name),
            DATAManager.GetDBValue("RoleInfo", "BodyType",name),
            DATAManager.GetDBValue("RoleInfo", "SkinColor", name),
            DATAManager.GetDBValue("RoleInfo", "PrefabKind", name)
        }, status);
    }

    public CharactorModel(int rowID, ROLESTATUS _status)
    {
        string[] info = DATAManager.GetSingleCharactorInfo(rowID);
        roleName = info[0];
        bodyModel = new BodyModel(new string[] { info[1], info[2], info[3], info[4] }, _status);
    }

    public void SetRoleStatus(ROLESTATUS _status)
    {
        status = _status;
    }
}