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


    public CharactorModel(string[] _info)
    {
        roleName = _info[0];
        status = ROLESTATUS.Naked;
        bodyModel = new BodyModel(new string[] { _info[1], _info[2], _info[3], _info[4]}, status);
    }

    public void SetRoleStatus(ROLESTATUS _status)
    {
        status = _status;
    }
}