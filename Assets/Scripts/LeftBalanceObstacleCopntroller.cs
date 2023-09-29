using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftBalanceObstacleCopntroller : MonoBehaviour
{
    public bool playerOnLeftBalance;
    [SerializeField] Transform balancePanel;

    private void Awake()
    {
        playerOnLeftBalance = false;
    }

    private void Update()
    {
        if (playerOnLeftBalance)
        {
            balancePanel.Rotate(0f, 0f, 0.003f * Time.deltaTime);
            playerOnLeftBalance = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && playerOnLeftBalance == false)
        {
            playerOnLeftBalance = true;
        }
    }
}
