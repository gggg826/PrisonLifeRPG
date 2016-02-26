/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;

public class NewBehaviourScript : MonoBehaviour 
{
    private Rect windowRect = new Rect(20, 20, 120, 50);
    private Rect windowRect2 = new Rect(80, 20, 120, 50);
    void OnGUI() {
        windowRect = GUI.Window(0, windowRect, DoMyFirstWindow, "First");
        windowRect2 = GUI.Window(1, windowRect2, DoMySecondWindow, "Second");
    }
    void DoMyFirstWindow(int windowID) {
        if (GUI.Button(new Rect(10, 20, 100, 20), "Put Back"))
            GUI.BringWindowToBack(0);
        
        GUI.DragWindow(new Rect(0, 0, 100, 20));
    }
    void DoMySecondWindow(int windowID) {
        if (GUI.Button(new Rect(10, 20, 100, 20), "Put Back"))
            GUI.BringWindowToBack(1);
        
        GUI.DragWindow(new Rect(0, 0, 100, 20));
    }
}