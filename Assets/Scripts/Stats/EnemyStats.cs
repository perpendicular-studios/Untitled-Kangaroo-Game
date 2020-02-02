using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyStats : EntityStats
{
    
    void Awake()
    {
        maxHealth = 100;
    }

    public override void Die()
    {
        base.Die();

        // Add ragdoll effect

        Destroy(gameObject);
    }
}
