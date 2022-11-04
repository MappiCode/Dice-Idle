using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points_Manager : MonoBehaviour
{
    public static double points = 0;

    public static double addPoints(double p)
    {
        points += p;
        return points;
    }

    public static double removePoints(double p)
    {
        points -= p;
        if (points < 0)
        {
            points += p;
            return -1;
        }
        return points;
    }
}
