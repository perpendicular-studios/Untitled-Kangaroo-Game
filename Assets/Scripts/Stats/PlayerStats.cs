using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : EntityStats  
{
    public int playerWater;

    public float jumpVelocity;
    public float fallMultiplier;

    void Start()
    {
        entitySpeed = 5;
    }
    public override void Die()
    {
        base.Die();

        // Add ragdoll effect

        Destroy(gameObject);
    }

}
