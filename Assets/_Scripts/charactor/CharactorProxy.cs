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
    public CharactorModel GetModelByName(string tableName, string name, ROLESTATUS status)
    {
        return new CharactorModel(tableName, name, status);
    }

    public CharactorModel GetModelByRowID(string tableName, int rowID, ROLESTATUS status)
    {
        return new CharactorModel(tableName, rowID, status);
    }
}