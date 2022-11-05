using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "New BonusMultiplierUpgrade", menuName = "Upgrades/BonusMultiplier")]
public class BonusMultiplierUpgrade : Upgrade
{
    [SerializeField] protected float _effectBonusMultiplier;
    [HideInInspector] public float effectBonusMultiplier;

    new void OnEnable()
    {
        base.OnEnable();
        effectBonusMultiplier = _effectBonusMultiplier;
    }
}
