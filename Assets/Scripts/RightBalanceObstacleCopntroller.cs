using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightBalanceObstacleCopntroller : MonoBehaviour
{
    public bool playerOnRightBalance;
    [SerializeField] Transform balancePanel;

    private void Awake()
    {
        playerOnRightBalance = false;
    }

    private void Update()
    {
        if(playerOnRightBalance)
        {
            balancePanel.Rotate(0f, 0f, -4f);
            playerOnRightBalance=false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player" && playerOnRightBalance==false)
        {
            playerOnRightBalance = true;
        }
    }
}
