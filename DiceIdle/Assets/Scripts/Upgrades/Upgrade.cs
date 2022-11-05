using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "New Upgrade", menuName = "Upgrades/Upgrade")]
public class Upgrade : ScriptableObject
{
    [SerializeField] protected int _count;
    [HideInInspector] public int count;
    [SerializeField] protected string _name;
    [HideInInspector] public new string name;
    [SerializeField] protected string _description;
    [HideInInspector] public string description;

    [SerializeField] protected Sprite _icon;
    [HideInInspector] public Sprite icon;

    [SerializeField] protected double _price;
    [HideInInspector] public double price;
    [SerializeField] protected float _priceMultiplier;
    [HideInInspector] public float priceMultiplier;

    protected void OnEnable()
    {
        count = _count;
        name = _name;
        description = _description;
        icon = _icon;
        price = _price;
        priceMultiplier = _priceMultiplier;
    }
}
