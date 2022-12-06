using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UIElements;

public class UI_Controller : MonoBehaviour
{
    public GameObject canvas;

    private static TextMeshProUGUI pointsValueTMP;

    void Start()
    {
        TextMeshProUGUI [] TMProUGUIs = FindObjectsOfType<TextMeshProUGUI>();
        foreach (TextMeshProUGUI m in TMProUGUIs)
        {
            if (m.CompareTag("Value Label") && m.name.StartsWith("Points"))
            {
                pointsValueTMP = m;
            }
        }
    }

    void Update()
    {
        UpdatePoints();
    }

    public static void UpdatePoints()
    {
        double points = Points_Manager.points;
        int powerOf10 = (int) Math.Floor(Math.Log10(points));
        string pointsText = points.ToString();

        if(powerOf10 > 2)
            switch(powerOf10 % 3)
            {
                case 0:
                    pointsText = pointsText.Substring(0, 1) + ',' + pointsText.Substring(1, 3);
                    break;
                case 1:
                    pointsText = pointsText.Substring(0, 2) + ',' + pointsText.Substring(2, 3);
                    break;
                case 2:
                    pointsText = pointsText.Substring(0, 3) + ',' + pointsText.Substring(3, 3);
                    break;
            }

        switch (powerOf10)
        {
            case var expression when powerOf10 < 3:
                break;
            case var expression when powerOf10 < 6:
                pointsText += " thousand";
                break;
            case var expression when powerOf10 < 9:
                pointsText += " million";
                break;
            case var expression when powerOf10 < 12:
                pointsText += " billion";
                break;
            case var expression when powerOf10 < 15:
                pointsText += " trillion";
                break;
        }

        pointsValueTMP.text = pointsText;
    }
}
