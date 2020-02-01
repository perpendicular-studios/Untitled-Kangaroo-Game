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
    public float playerSpeed;
    public float jumpVelocity;
    public float fallMultiplier;

    
}
