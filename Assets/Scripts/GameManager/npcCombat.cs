using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(NPCStats))]
public class NPCCombat : MonoBehaviour
{
    NPCStats myStats;

    void Start() {
        myStats = GetComponent<NPCStats>();
    }
    
    public void Attack(NPCStats targetStats)
    {
        targetStats.TakeDamage(20);
    }
}
