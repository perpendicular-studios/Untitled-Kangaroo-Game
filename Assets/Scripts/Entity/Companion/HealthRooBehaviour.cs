using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthRooBehaviour : CompanionBehaviour
{
    int healthAdder = 20;
    
    public override void OnRescue() {
        if (!hasMaster) {
            hasMaster = !hasMaster;
            stats.maxHealth = stats.maxHealth+healthAdder;
            stats.currentHealth = stats.currentHealth+healthAdder;
            Debug.Log(stats.maxHealth);
        }
    }
}
