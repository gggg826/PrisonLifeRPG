/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using UnityEditor;

public class ToolsGUI : EditorWindow
{
    static public void InitToolsWindow()
    {
        EditorWindow.GetWindow(typeof(ToolsGUI));
    }

    void OnGUI()
    {
        string title = "\n" +
                       "   ==============" + "\n" +
                       "   **********************" + "\n" +
                       "   *  Author : TheNO.5   *" + "\n" +
                       "   **********************" + "\n" +
                       "   ==============";

        GUIStyle lableStyle = new GUIStyle();
        lableStyle.normal.background = null;
        lableStyle.normal.textColor = new Color(0, 1, 0);
        lableStyle.fontSize = 20;
        GUILayout.Label(title, lableStyle);
        GUILayout.Label("\n");


        if (GUILayout.Button("Export CharactorInfo By Selected", GUILayout.MaxWidth(200)))
        {
            Tools.ExportCharactorInfo();
        }
        GUILayout.Label("\n");



        Texture xml = EditorGUILayout.ObjectField("这个暂时没有用", null, typeof(Texture), true) as Texture;
        if (GUILayout.Button("Change XML To SQLiteDB"))
        {
            Tools.XMLToSQLiteDatabase();
        }
        GUILayout.Label("\n");
        
        
        
        
        
        
        
        
        GUILayout.Label("\n");
        GUILayout.Label("\n");
        GUILayout.Label("\n");
        GUILayout.Label("\n");
        GUILayout.Label("\n");
        GUILayout.Label("\n");
        GUILayout.Label("以下是代码示例", lableStyle);
        EditorGUILayout.BeginFadeGroup(1);
        GUILayout.Label("\n");
        
        EditorGUILayout.BeginHorizontal();
        GUILayout.Label("我是文本输入框");
        string text = EditorGUILayout.TextField("Write something");
        EditorGUILayout.EndHorizontal();

        bool isToggle = true;
        bool[] toggle = new bool[] { true, true, false };
        isToggle = EditorGUILayout.BeginToggleGroup("我是Toggle", isToggle);
        toggle[0] = EditorGUILayout.Toggle("X", toggle[0]);
        toggle[1] = EditorGUILayout.Toggle("Y", toggle[1]);
        toggle[2] = EditorGUILayout.Toggle("Z", toggle[2]);
        EditorGUILayout.EndToggleGroup();
       
       GUILayout.Label("\n");
       
        EditorGUILayout.BeginHorizontal();
        GUILayout.Label("选择渲染层");
        LayerMask layer = EditorGUILayout.LayerField(1);
        EditorGUILayout.EndHorizontal();
        
        
        string texa = EditorGUILayout.TextArea("aa");
        string texf = EditorGUILayout.TextField("aa");
        
    }
}