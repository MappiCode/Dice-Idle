using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

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
        pointsValueTMP.text = Points_Manager.points.ToString();
    }
}
