using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowTrigger : MonoBehaviour
{
    public bool CamTriggered = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "CamTrigger" && CamTriggered == false)
        {
            CamTriggered = true;
        }
    }

}
