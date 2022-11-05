using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Upgrade_Display : MonoBehaviour
{
    [SerializeField] private Upgrade upgrade;

    [SerializeField] private Image image;
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI descriptionText;
    [SerializeField] private TextMeshProUGUI priceText;

    void Start()
    {
        Refresh();
    }

    public void Refresh()
    {
        image.sprite = upgrade.icon;
        nameText.text = upgrade.name;
        descriptionText.text = upgrade.description;
        priceText.text = upgrade.price.ToString();
    }
}
