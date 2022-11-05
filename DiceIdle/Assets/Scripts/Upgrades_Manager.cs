using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Upgrades_Manager : MonoBehaviour
{
    [SerializeField] private List<Upgrade> _upgradeList = new List<Upgrade>();
    private static List<Upgrade> upgradeList;

    void Start()
    {
        upgradeList = _upgradeList;
    }

    public void BuyUpgrade(string upgradeName)
    {
        Upgrade upgrade = upgradeList.Where(up => up.name == upgradeName).FirstOrDefault();
        if (upgrade == null)
            return;
        if (Points_Manager.CanBuy(upgrade.price))
        {
            Points_Manager.RemovePoints(upgrade.price);
            upgrade.count++;
            upgrade.price *= upgrade.priceMultiplier;
        }
    }

    public static double GetRollMultiplier()
    {
        double tmp = 1;
        foreach (Upgrade upgrade in upgradeList)
        {
            if (upgrade.count == 0)
                continue;
            tmp *= upgrade.effectRollMultiplier * upgrade.count;
        }

        return tmp;
    }
}
