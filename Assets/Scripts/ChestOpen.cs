using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestOpen : MonoBehaviour
{
    public Animator chestOpen;
    bool ischestOpen;

    public Transform Blade;
    public Rigidbody2D blade;
    public float clampright;
    public float clampleft;

    private void Awake()
    {
        ischestOpen = false;
        blade.AddForce(Vector2.right * 100);
    }

    private void Update()
    {
        if (Blade.position.x > clampright)
        {
            //blade.transform.position = new Vector2(Blade.position.x, clampright);
            blade.velocity = Vector2.zero;
            blade.AddForce(Vector2.right * -100);
        }
        if(Blade.position.x < clampleft)
        {
            //blade.transform.position = new Vector2(Blade.position.x, clampleft);
            blade.velocity = Vector2.zero;
            blade.AddForce(Vector2.right * 100);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player" && !ischestOpen)
        {
            chestOpen.SetBool("ChestIsOpen", true);
            ischestOpen = true;
        }
    }
}
