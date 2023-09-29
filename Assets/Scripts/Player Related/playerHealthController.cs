using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealthController : MonoBehaviour
{
    public float PlayerHealth = 100;

    public GameObject playerrb;
    [SerializeField] bool isClimb = false;
    [SerializeField] float ladderMovementSpeed = 2f;
    //[SerializeField] GameObject PlayerPrefabInGame;
    public Animator player;
    /*private void Awake()
    {
        //PlayerPrefabInGame = GameObject.FindGameObjectWithTag("Player").GetComponent<GameObject>();
        playerrb = GameObject.FindGameObjectWithTag("Player").GetComponent<GameObject>();
    }*/
    private void Update()
    {
        if(PlayerHealth == 0)
        {
            player.SetBool("Death", true);
        }

        if(isClimb)
        {
                float v = Input.GetAxisRaw("Vertical");
                transform.position = transform.position + new Vector3(0f, v * ladderMovementSpeed * Time.deltaTime, 0);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "obstacle")
        {
            player.SetBool("Hurt", true);
            PlayerHealth -= 10;
        }
        if (collision.gameObject.tag == "ladder" && !isClimb)
        {
            isClimb = true;
        }
        if(collision.gameObject.tag == "bullet")
        {
            PlayerHealth -= 5;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ladder" && !isClimb)
        {
            isClimb = false;
        }
    }
}
