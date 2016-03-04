/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEditor;

public class MainMenu : EditorWindow
{
    [MenuItem("Tools/Open ToolsTemplate")]
    static void OpenTools()
    {
        ToolsGUI.InitToolsWindow();
    }
    
    [MenuItem("Assets/Sprite To Assetbundle")]
    static void SpriteToAssetbundle()
    {
        LETools.CreateSpriteAssetbundle();
    }
}