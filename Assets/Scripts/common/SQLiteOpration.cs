/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;
using Mono.Data.Sqlite;

public class SQLiteOpration
{
    private SqliteConnection dbConnection;
    private SqliteCommand dbCommand;
    private SqliteDataReader dbReader;

    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="path">DB文件路径</param>
    public SQLiteOpration(string path)
    {
        OpenDB(path);
    }

    void OpenDB(string path)
    {
        try
        {
            dbConnection = new SqliteConnection(@"Data Source=" + path);
            dbConnection.Open();
            Debug.Log("Sqlite Connected ");
        }
        catch (System.Exception e)
        {

            Debug.Log(e.ToString());
        }
    }

    public void CloseConnection()
    {
        if (dbCommand != null)
            dbCommand.Dispose();
        dbCommand = null;

        if (dbConnection != null)
            dbConnection.Dispose();
        dbConnection = null;

        Debug.Log("Disconnected to Sqlite");
    }

    /// <summary>
    /// 查询输出数据记录
    /// </summary>
    /// <param name="query"></param>
    /// <returns></returns>
    public SqliteDataReader ExecuteQuery(string query)
    {
        dbCommand = dbConnection.CreateCommand();
        dbCommand.CommandText = query;
        dbReader = dbCommand.ExecuteReader();

        return dbReader;
    }

    /// <summary>
    /// 查询输出所有数据记录
    /// </summary>
    /// <param name="tableName">数据表名称</param>
    /// <returns></returns>
    public SqliteDataReader ReadFullTable(string tableName)
    {
        string query = "SELECT * FROM " + tableName;
        return ExecuteQuery(query); 
    }

    /// <summary>
    /// 添加数据记录
    /// </summary>
    /// <param name="tableName">数据表名称</param>
    /// <param name="values">字段值</param>
    /// <returns></returns>
    public SqliteDataReader InsertInto(string tableName, string[] values)
    {
        string query = "INSERT INTO " + tableName + " VALUES(" + values[0];
        for (int i = 1; i < values.Length; ++i)
            query += ", " + values[i];
        query += ")";

        return ExecuteQuery(query);
    }

    /// <summary>
    /// 删除数据记录
    /// </summary>
    /// <param name="tableName">数据表名称</param>
    /// <param name="cols">字段名称</param>
    /// <param name="colsvalues">字段值</param>
    /// <returns></returns>
    public SqliteDataReader Delete(string tableName, string[] cols, string[] colsvalues)
    {
        string query = "DELETE FORM " + tableName + " WHERE " + cols[0] + " = " + colsvalues[0];
        for (int i = 1; i < colsvalues.Length; ++i)
            query += " OR " + cols[i] + " = " + colsvalues[i];
        return ExecuteQuery(query);
    }

    /// <summary>
    /// 修改数据记录
    /// </summary>
    /// <param name="tableName">数据表名称</param>
    /// <param name="cols">字段</param>
    /// <param name="colsvalues">字段值</param>
    /// <param name="selectedKey"></param>
    /// <param name="selectedvale"></param>
    /// <returns></returns>
    public SqliteDataReader UpdateInto(string tableName, string[] cols, string[] colsvalues, string selectedKey, string selectedvale)
    {
        string query = "UPDATE " + tableName + " SET " + cols[0] + " = " + colsvalues[0];
        for(int i = 1; i < colsvalues.Length; ++i)
            query += ", " + cols[i] + " = " + colsvalues[i];
        query += " WHERE " + selectedKey + " = " + selectedvale;

        return ExecuteQuery(query);
    }

    /// <summary>
    /// 添加数据记录
    /// </summary>
    /// <param name="tableName">数据表名称</param>
    /// <param name="cols">字段名称</param>
    /// <param name="values">字段值</param>
    /// <returns></returns>
    public SqliteDataReader InsertIntoSpecific(string tableName, string[] cols, string[] values)

    {
        if (cols.Length != values.Length)
            throw new SqliteException("columns.Length != values.Length");

        string query = "INSERT INTO " + tableName + "(" + cols[0];
        for (int i = 1; i < cols.Length; ++i)
            query += ", " + cols[i];
        query += ") VALUES (" + values[0];
        for (int i = 1; i < values.Length; ++i)
            query += ", " + values[i];
        query += ")";

        return ExecuteQuery(query);
    }

    public SqliteDataReader DeleteContents(string tableName)
    {
        string query = "DELETE FROM " + tableName;
        return ExecuteQuery(query);
    }

    /// <summary>
    /// 建立数据表
    /// </summary>
    /// <param name="name">数据表名称</param>
    /// <param name="col">字段名称</param>
    /// <param name="colType">字段类型</param>
    /// <returns></returns>
    public SqliteDataReader CreateTable(string name, string[] col, string[] colType)
    {
        if (col.Length != colType.Length)
            throw new SqliteException("columns.Length != colType.Length");

        string query = "CREATE TABLE " + name + " (" + col[0] + " " + colType[0];
        for (int i = 1; i < col.Length; ++i)
            query += ", " + col[i] + " " + colType[i];
        query += ")";

        return ExecuteQuery(query);
    }

    public SqliteDataReader SelectWhere(string tableName, string[] items, string[] col, string[] operation, string[] values)
    {
        if (col.Length != operation.Length || operation.Length != values.Length)
            throw new SqliteException("col.Length != operation.Length != values.Length");

        string query = "SELECT " + items[0];
        for (int i = 1; i < items.Length; ++i)
            query += ", " + items[i];
        query += " FROM " + tableName + " WHERE " + col[0] + operation[0] + "'" + values[0] + "' ";

        for (int i = 1; i < col.Length; ++i)
            query += " AND " + col[i] + operation[i] + "'" + values[0] + "' ";

        return ExecuteQuery(query);
    }
}