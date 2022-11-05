using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "New Upgrade", menuName = "Upgrade")]
public class Upgrade : ScriptableObject
{
    [SerializeField] private int _count;
    [HideInInspector] public int count;
    [SerializeField] private string _name;
    [HideInInspector] public new string name;
    [SerializeField] private string _description;
    [HideInInspector] public string description;

    [SerializeField] private Sprite _icon;
    [HideInInspector] public Sprite icon;

    [SerializeField] private double _price;
    [HideInInspector] public double price;
    [SerializeField] private float _priceMultiplier;
    [HideInInspector] public float priceMultiplier;

    [SerializeField] private float _effectRollMultiplier;
    [HideInInspector] public float effectRollMultiplier;
    [SerializeField] private float _effectBonusMultiplier;
    [HideInInspector] public float effectBonusMultiplier;

    private void OnEnable()
    {
        count = _count;
        name = _name;
        description = _description;
        icon = _icon;
        price = _price;
        priceMultiplier = _priceMultiplier;
        effectRollMultiplier = _effectRollMultiplier;
        effectBonusMultiplier = _effectBonusMultiplier;
    }
}
