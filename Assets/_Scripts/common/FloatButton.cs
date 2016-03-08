/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;

public class FloatButton : UnitySingletonG<FloatButton>
{
    private Rect floatButton = new Rect(-30, Screen.height / 3, 120, 80);
    public void GetFloatButton()
    {

    }

    void OnGUI()
    {
        GUI.backgroundColor = Color.yellow;
        floatButton = GUI.Window(0, floatButton, ShowAllRoles, "浮动按钮");
    }


    void ShowAllRoles(int id)
    {
        GUI.backgroundColor = Color.blue;
        if (GUILayout.Button("显示所有人物"))
            Application.LoadLevel(1);
        if (GUILayout.Button("返回"))
        {
            Application.LoadLevel(0);
            //Resources.UnloadUnusedAssets();
        }


        GUI.DragWindow(new Rect(0, 0, Screen.width, Screen.height));
    }
}