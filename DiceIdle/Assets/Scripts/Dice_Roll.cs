using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Dice_Roll : MonoBehaviour
{
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMouseDown(){
        Debug.Log("Dice got clicked");
        transform.position = new Vector3(0, 3, 0);
        transform.rotation = Quaternion.identity;
        rb.velocity = new Vector3(Random.Range(-5f, 5f), 0, Random.Range(-5f, 5f));
        rb.AddTorque(rb.velocity*20);
        //rb.AddTorque(Random.Range(-90f, 90f), Random.Range(-90f, 90f), Random.Range(-90f, 90f));

        UI_Controller.UpdatePoints(Random.Range(1, 6));
    }
}
