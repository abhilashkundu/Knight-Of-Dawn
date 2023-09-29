using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sheildSensorController : MonoBehaviour
{
    public bool shieldup = false;
    void Update()
    {
        if (Input.GetMouseButtonDown(1) && !shieldup)
        {
            shieldup = true;
        }
    }
}
