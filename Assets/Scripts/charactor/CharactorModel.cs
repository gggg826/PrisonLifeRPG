/*****************************
*
*  Author : TheNO.5
*
******************************/


public class CharactorModel
{
    public string roleName;
    public BodyModel bodyModel;


    public CharactorModel(string[] _info)
    {
        roleName = _info[0];
        bodyModel = new BodyModel(new string[] { _info[1], _info[2], _info[3], _info[4]});
    }
}