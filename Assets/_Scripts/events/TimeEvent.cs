/*****************************
*
*  Author : TheNO.5
*
******************************/

 
using UnityEngine;
using System.Collections;

public class TimeEvent : UnitySingletonG<TimeEvent>
{
    public string GetTimeFor12h(int time)
    {
        if (time <= 12)
            return time + ":00 AM";
        else
            return (time - 12) + ":00 PM";
    }
}