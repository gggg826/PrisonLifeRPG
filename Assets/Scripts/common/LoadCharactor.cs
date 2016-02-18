/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;
using UnityEngine.UI;

public class LoadCharactor : MonoBehaviour
{
    public Transform canvasTran;

    void Start ()
    {
        GameObject go = (GameObject)Instantiate(Resources.Load("Prefabs/Charactor"));
        go.transform.SetParent(canvasTran);
        go.transform.localPosition = Vector3.zero;
        CharactorUI charUI = go.GetComponent<CharactorUI>();

        charUI.InitCharactorUI("prisonChar_headg11");

    }
}