using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class bulletController : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;

    [SerializeField] float moveSpeed;

    [SerializeField] Transform target;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("P_health").GetComponent<Transform>();

        Vector2 distance = (target.position - transform.position).normalized * moveSpeed;
        rb.velocity = new Vector2(distance.x, distance.y);

        Destroy(gameObject,5f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "sheild" && Input.GetMouseButton(1))
        {
             Destroy(this.gameObject);
        }
    }
}
