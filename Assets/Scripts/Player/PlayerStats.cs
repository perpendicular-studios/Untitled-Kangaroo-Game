using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerStats : MonoBehaviour
{
    [Header("Player Stats")]
    public int playerHealth = 100;
    public int playerWater;

    [Header("Player Movement")]
    public float playerSpeed = 10;
    public float jumpForce;

    // public void TakeDamage(int damage)
    // {
    //     playerHealth -= damage;
    //     if (playerHealth <= 0) {
    //         Die();
    //     }
    // }

    // private void Die()
    // {

    // }

}
