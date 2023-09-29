using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWallPlatform2 : MonoBehaviour
{
    [SerializeField] GameObject SecretWallObj;
    [SerializeField] bool istriggered = false;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player" && !istriggered)
        {
            SecretWallObj.SetActive(false);
            istriggered=true;
        }
    }
}
