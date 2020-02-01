using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    public static PlayerManager instance;
    public PlayerMovement player;

    void Awake() {
        instance = this;
    }


    public void TakeDamage(int damage)
    {
        player.stats.playerHealth -= damage;
        if (player.stats.playerHealth <= 0) {
            Die();
        }
    }

    private void Die()
    {

    }

    void Update()
    {

    }
}
