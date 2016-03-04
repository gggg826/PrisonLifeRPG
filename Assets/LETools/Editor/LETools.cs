/*****************************
*
*  Author : TheNO.5
*
******************************/

using UnityEngine;
using UnityEditor;
using System.IO;
using System.Collections.Generic;

public class LETools : Editor
{
    static public void XMLToSQLiteDatabase()
    {
        string path1 = EditorUtility.OpenFilePanel("选择xml文件", Application.dataPath + "/Tools/Example/Data", "xml");

        string path2 = EditorUtility.SaveFilePanel("选择保存SQLite DB文件的位置", null, "SQLiteDB", "db");

        XMLOpration.XMLToSQLiteDatabase(path1, path2);

        AssetDatabase.Refresh();
    }

    static public void LogSelectAssetsPath()
    {
        foreach (string item in GetSelectedPathes())
        {
            Debug.Log(item);
        }
    }

    static public void CreateSpriteAssetbundle()
    {
        string path = Application.streamingAssetsPath + "Sprtes";
        if (Directory.Exists(path))
            Directory.Delete(path);
        DirectoryInfo root = new DirectoryInfo(GetSingleSelectedPath());
        
        string namePath = path + root.Name + ".assetbundle";
        if(Directory.Exists(namePath))
            Directory.Delete(namePath);
        
        List<Sprite> list = new List<Sprite>();
        foreach (FileInfo item in root.GetFiles("*.png", SearchOption.AllDirectories))
        {
            string loadPath = item.FullName.Substring(item.FullName.IndexOf("Assets"));
            list.Add(AssetDatabase.LoadAssetAtPath<Sprite>(loadPath));
        }
        BuildPipeline.BuildAssetBundle(null, list.ToArray(), namePath, BuildAssetBundleOptions.UncompressedAssetBundle | BuildAssetBundleOptions.CollectDependencies, GetBuildTarget());
    }
    
    
    static private BuildTarget GetBuildTarget()
    {
        BuildTarget target = BuildTarget.WebPlayer;
#if UNITY_STANDALONE
			target = BuildTarget.StandaloneWindows;
#elif UNITY_IPHONE
        target = BuildTarget.iOS;
#elif UNITY_ANDROID
			target = BuildTarget.Android;
#endif
        return target;
    }


    static string GetSingleSelectedPath()
    {
        string[] path = Selection.assetGUIDs;
        if (path.Length == 0)
        {
            EditorUtility.DisplayDialog("", "Select Something", "OK");
            return null;
        }

        else if (path.Length > 1)
        {
            EditorUtility.DisplayDialog("", "Just Do Single Select", "OK");
            return null;
        }

        // string temp = AssetDatabase.GUIDToAssetPath(path[0]);
        // return (Application.dataPath + temp.Replace("Assets", ""));
        return AssetDatabase.GUIDToAssetPath(path[0]);
    }

    static List<string> GetSelectedPathes()
    {
        string[] path = Selection.assetGUIDs;
        if (path.Length == 0)
        {
            EditorUtility.DisplayDialog("", "Select Something", "OK");
            return null;
        }

        List<string> list = new List<string>();
        foreach (string item in path)
        {
            string temp = AssetDatabase.GUIDToAssetPath(item);
            list.Add(Application.dataPath + temp.Replace("Assets", ""));
        }
        return list;
    }
}