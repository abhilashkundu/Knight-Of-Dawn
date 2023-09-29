using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class ETBotController : MonoBehaviour
{
    [SerializeField] isPlayerNearBot is_player_near_bot;
    [SerializeField] Transform player;
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject fightdomb;
    [SerializeField] Transform gunpoint;
    [SerializeField] Animator ETanim;
    [SerializeField] float firerate;
    [SerializeField] float firetime;
    [SerializeField] float EnemyMag = 20;
    [SerializeField] float TimeForEnemyReload;
    [SerializeField] float EThealth = 100;
    SwordAttackSensor ishit;
    bool isdie = false;
    int i;

    private void Start()
    {
        firetime = Time.time;
        i = 0;
    }

    void Update()
    {
        if (is_player_near_bot.playerNearBot == true)
        {
            fightdomb.SetActive(true);

            //ETanim.SetBool("enemySense", true);
            if (ETanim.GetBool("enemyAlert") == false && i == 0)
            {
                EnemyAlert();
            }

            if (player.position.x > transform.position.x)
            {
                PlayerOnRight();
            }
            if (player.position.x < transform.position.x)
            {
                PlayerOnLeft();
            }

            if (Time.time > firetime && isdie == false && EnemyMag > 0)
            {
                firetime = Time.time + firerate;
                Instantiate(bullet, gunpoint.position, transform.rotation);
                EnemyMag -= 1;
                TimeForEnemyReload = Time.time;
            }

            if(EnemyMag == 0 && TimeForEnemyReload > 7f)
            {
                EnemyMag = 20;
                TimeForEnemyReload = 0;
            }
        }

        if (EThealth <= 0)
        {
            ETanim.SetBool("die", true);
            isdie = true;
        }
    }

    private void EnemyAlert()
    {
        Debug.Log("Alert");
        ETanim.SetBool("enemyAlert", true);
        StartCoroutine(Countdown2());
        ETanim.SetBool("enemyAlert", false);
        i = 1;
    }

    private void PlayerOnLeft()
    {
        Debug.Log("Left");
        ETanim.SetBool("playerIsOnRight", false);
        ETanim.SetBool("playerIsOnLeft", true);
    }

    private void PlayerOnRight()
    {
        Debug.Log("Right");
        ETanim.SetBool("playerIsOnLeft", false);
        ETanim.SetBool("playerIsOnRight", true);
    }

    private IEnumerator Countdown2()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "sword" && Input.GetMouseButton(0))
        {
            EThealth -= 10;
        }
    }
}
