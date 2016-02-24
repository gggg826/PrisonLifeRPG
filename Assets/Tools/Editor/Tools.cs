/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class Tools : Editor
{
    static public void ExportCharactorInfo()
    {
        Object[] objs = UnityEditor.Selection.GetFiltered(typeof(GameObject), SelectionMode.DeepAssets);
        
        if(objs.Length == 0)
        {
            EditorUtility.DisplayDialog("Warning:", "Please Selecte Something", "OK");
        }
        
        string savePath = EditorUtility.SaveFolderPanel("Choose Save Folder", Application.dataPath, "xml");
        
        foreach(GameObject go in objs)
        {
            string name = go.name;
            string head = go.transform.Find("Head").GetComponent<Image>().sprite.name;
            string body = go.transform.Find("Body").GetComponent<Image>().sprite.name;
            string hand = go.transform.Find("RHand").GetComponent<Image>().sprite.name;
            string leg = go.transform.Find("RLeg").GetComponent<Image>().sprite.name;
            
            Debug.Log(name + "\n" + head + "\n" + body + "\n" + hand + "\n" + leg);
        }
    }
    
    static public void XMLToSQLiteDatabase()
    {
        string path1 = EditorUtility.OpenFilePanel("选择xml文件","","xml" );
        
        string path2 = EditorUtility.SaveFilePanel("选择保存SQLite DB文件的位置", null, null,"db");
        
        XMLOpration.XMLToSQLiteDatabase(path1, path2);
    }
}