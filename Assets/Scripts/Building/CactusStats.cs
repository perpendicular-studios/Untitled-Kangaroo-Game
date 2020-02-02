using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusStats : BuildingStats
{
    public PlayerStats stats;

    private void Awake()
    {
        maxHealth = 100;
    }


    public override void Oninteract()
    {
        InteractText = "Press E to Interact";
        // stats.playerWater += 15;

    }



}
