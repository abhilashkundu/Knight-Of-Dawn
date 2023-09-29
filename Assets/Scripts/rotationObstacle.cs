using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationObstacle : MonoBehaviour
{
    [SerializeField] Transform spikes;
    [SerializeField] float rotationSpeed;
    private void Update()
    {
        spikes.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
    }
}
