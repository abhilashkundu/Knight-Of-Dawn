using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Vector3 offset = new Vector3(0f, 2f, -20f);
    float smoothTime = 0.25f;
    Vector3 Velocity = Vector3.zero;

    [SerializeField] Transform Target;

    [SerializeField] CamFollowTrigger trigger;

    private void FixedUpdate()
    {
        if(trigger.CamTriggered == true)
        {

            transform.position = Target.transform.position + offset;

            transform.position = Vector3.SmoothDamp(transform.position, Target.position, ref Velocity, smoothTime);
        }
    }
}
