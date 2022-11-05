using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points_Manager : MonoBehaviour
{
    public static double points = 0;

    public static double AddPoints(double p)
    {
        points += ApplyEffects(p);
        return points;
    }

    public static double RemovePoints(double p)
    {
        points -= p;
        if (points < 0)
        {
            points += p;
            return -1;
        }
        return points;
    }

    public static bool CanBuy(double cost)
    {
        if (points < cost)
            return false;
        return true;
    }

    private static double ApplyEffects(double p)
    {
        p *= Upgrades_Manager.GetRollMultiplier();
        return p;
    }
}
