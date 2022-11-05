using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "New RollMultiplierUpgrade", menuName = "Upgrades/RollMultiplier")]
public class RollMultiplierUpgrade : Upgrade
{
    [SerializeField] protected float _effectRollMultiplier;
    [HideInInspector] public float effectRollMultiplier;
    
    new void OnEnable(){
        base.OnEnable();
        effectRollMultiplier = _effectRollMultiplier;
    }
}
