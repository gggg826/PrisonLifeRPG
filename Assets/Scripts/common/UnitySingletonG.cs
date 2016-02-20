/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
public class UnitySingletonG<T>: MonoBehaviour where T : Component
{
    private static T _instance;
    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject obj = new GameObject("UnitySingletonG");
                //obj.hideFlags = HideFlags.HideAndDontSave;
                DontDestroyOnLoad(obj);
                _instance = obj.AddComponent(typeof(T)) as T;
            }
            return _instance;
        }
    }
}