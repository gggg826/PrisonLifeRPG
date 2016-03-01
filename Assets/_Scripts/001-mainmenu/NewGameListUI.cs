/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;
using System.Collections;

public class NewGameListUI : MonoBehaviour
{
    private Transform list1;
    private Transform list2;
    private Transform list3;
    private Transform list4;
    private Transform list5;

	void Start ()
    {
        list1 = transform.Find("List1").transform;
        list2 = transform.Find("List2").transform;
        list3 = transform.Find("List3").transform;
        list4 = transform.Find("List4").transform;
        list5 = transform.Find("List5").transform;

        CharactorsController.Instance.AddRoleToScreen(1, ROLESTATUS.Normal, list1);
        CharactorsController.Instance.AddRoleToScreen(2, ROLESTATUS.Normal, list2);
        CharactorsController.Instance.AddRoleToScreen(3, ROLESTATUS.Normal, list3);
        CharactorsController.Instance.AddRoleToScreen(4, ROLESTATUS.Normal, list4);
        CharactorsController.Instance.AddRoleToScreen(5, ROLESTATUS.Normal, list5);
    }
}