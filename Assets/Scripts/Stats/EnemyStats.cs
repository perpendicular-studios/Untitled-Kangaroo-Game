using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyStats : EntityStats
{
    
    public int dealDamage;

    void Awake()
    {
        maxHealth = currentHealth;
    }

    public int MaxHealth
    {
        get { return maxHealth; }
        set { maxHealth = value; }
    }

    public override void Die()
    {
        base.Die();

        // Add ragdoll effect

        Destroy(gameObject);
    }
}
