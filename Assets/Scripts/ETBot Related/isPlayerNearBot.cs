using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isPlayerNearBot : MonoBehaviour
{
    public bool playerNearBot;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            playerNearBot = true;
        }
    }
}
