using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InteractWallPlatform : MonoBehaviour
{
    [SerializeField] Transform W_I_Obj1;
    [SerializeField] Animator Obj_Itself_Animation;
    [SerializeField] bool istriggered = false;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player" && istriggered == false)
        {
            Obj_Itself_Animation.SetBool("KeyTriggered", true);
            W_I_Obj1.Rotate(0f, 0f, 90f);
            istriggered = true;
        }
    }
}
