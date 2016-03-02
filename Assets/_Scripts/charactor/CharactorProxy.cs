/*****************************
*
*  Author : TheNO.5
*
******************************/



public class CharactorProxy : UnitySingletonG<CharactorProxy>
{
    /// <summary>
    /// xml
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public CharactorModel GetRoleInfoByName(string name)
    {
        CharactorModel roleInfo;
        DATAManager.RolseInfo.TryGetValue(name, out roleInfo);
        return roleInfo;
    }
    
    /// <summary>
    ///Database 
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public CharactorModel GetRoleDBByName(string name, ROLESTATUS status)
    {
        return new CharactorModel(name, status);
    }

    public CharactorModel GetRoleDBByRowID(int rowID, ROLESTATUS status)
    {
        return new CharactorModel(rowID, status);
    }
}