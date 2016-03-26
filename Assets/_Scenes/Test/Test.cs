/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{
    private ArrayList list = new ArrayList();
    void Awake()
    {

    }

    void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            list.Add(i);
        }

        ChangeSort(list);
    }

    void PrintArraylist(ArrayList arr)
    {
        // ArrayList temp = arr.GetRange(0, 5);
        for (int i = 0; i < arr.Count; i++)
        {
            print("NO=" + i + "   " + arr.IndexOf(Random.Range(0, arr.Count)));
        }
        
    }
    
    void ChangeSort(ArrayList arr)
    {
        int[] nolist = new int[arr.Count];
        for (int i = 0; i < nolist.Length; i++)
        {
            nolist[i] = arr.IndexOf(i);
        }
        
        for (int i = 0; i < nolist.Length; i++)
        {
            int temp = nolist[i];
            int index = Random.Range(0, nolist.Length);
            nolist[i]= nolist[index];
            nolist[index] = temp;
        }
        
        for (int i = 0; i < nolist.Length; i++)
        {
            print("NO=" + i + "   " + nolist[i]);
        }
    }
}