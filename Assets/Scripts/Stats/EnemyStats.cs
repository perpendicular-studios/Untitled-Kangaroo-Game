﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyStats : EntityStats
{
    // Start is called before the first frame update
    
    void Start()
    {
        maxHealth = 20;
    }

    public override void Die()
    {
        base.Die();

        // Add ragdoll effect

        Destroy(gameObject);
    }
}
