using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Dice_Roll : MonoBehaviour
{
    private Rigidbody rb;
    private bool isMoving;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (isMoving && rb.velocity.magnitude == 0)
        {
            Points_Manager.addPoints(CheckValue());
            isMoving = false;
        }
    }

    void OnMouseDown(){
        // no action if dice is still rolling
        if (isMoving)
            return;

        transform.position = new Vector3(0, 3, 0);
        transform.rotation = Quaternion.identity;
        rb.velocity = new Vector3(Random.Range(-5f, 5f), 0, Random.Range(-5f, 5f));
        rb.AddTorque(rb.velocity*20);
        isMoving = true;
        //rb.AddTorque(Random.Range(-90f, 90f), Random.Range(-90f, 90f), Random.Range(-90f, 90f));
    }

    byte CheckValue()
    {
        int x = Mathf.RoundToInt(transform.rotation.eulerAngles.x);
        int y = Mathf.RoundToInt(transform.rotation.eulerAngles.y);
        int z = Mathf.RoundToInt(transform.rotation.eulerAngles.z);

        x = x > 180 ? x - 360 : x;
        y = y > 180 ? y - 360 : y;
        z = z > 180 ? z - 360 : z;

        bool xbool = x % 90 == 0;
        bool ybool = y % 90 == 0;
        bool zbool = z % 90 == 0;

        switch ((xbool, ybool, zbool))
        {
            case (true, false, true) when x == 0 && z == 0:
                return 1;
            case (true, false, true) when x == -90 && z == 0:
                return 2;
            case (true, false, true) when x == 0 && z == 90:
                return 3;
            case (true, false, true) when x == 0 && z == -90:
                return 4;
            case (true, false, true) when x == 90 && z == 0:
                return 5;
            case (true, false, true) when x == 0 && z == 180:
                return 6;
        }
        return 0;
    }
}
