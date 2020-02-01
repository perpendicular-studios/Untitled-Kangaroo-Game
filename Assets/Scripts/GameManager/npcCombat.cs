using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(npcStats))]
public class npcCombat : MonoBehaviour
{
    npcStats myStats;

    void Start() {
        myStats = GetComponent<npcStats>();
    }
    
    public void Attack(npcStats targetStats)
    {
        targetStats.TakeDamage(20);
    }
}
