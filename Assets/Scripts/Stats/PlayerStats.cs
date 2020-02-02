using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : EntityStats  
{
    public int playerWater;

    public float jumpVelocity;
    public float fallMultiplier;

    public int maxCompanions;

    public int currentCompanions
    {	
        get;	
        set;	
    }

    void Awake()
    {
        maxHealth = 50;
        entitySpeed = 5;
        maxCompanions = 2;
        currentCompanions = 0;
    }
    public override void Die()
    {
        base.Die();
        // Add ragdoll effect

        Destroy(transform.parent.gameObject);

    }

}
