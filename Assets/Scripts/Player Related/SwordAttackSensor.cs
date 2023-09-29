using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SwordAttackSensor : MonoBehaviour
{
    public bool hit = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !hit)
        {
            hit = true;
        }
    }
}
