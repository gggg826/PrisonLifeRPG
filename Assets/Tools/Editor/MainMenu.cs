/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using UnityEditor;

public class MainMenu : EditorWindow 
{
    [MenuItem("Tools/Open Tools")]
    static void OpenTools()
    {
        ToolsGUI.InitToolsWindow();
    }
}