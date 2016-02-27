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
            CommonDATA.GetDBValue("RoleInfo", "HeadNo", name),
            CommonDATA.GetDBValue("RoleInfo", "BodyType", name),
            CommonDATA.GetDBValue("RoleInfo", "SkinColor", name),
            CommonDATA.GetDBValue("RoleInfo", "PrefabKind", name)
        }, status);
    }

    public void SetRoleStatus(ROLESTATUS _status)
    {
        status = _status;
    }
}