using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireStationStats : BuildingStats
{
    private GameObject player;
    public int radius = 10;
    public int regen_Rate = 20;
    private void Awake()
    {
        maxHealth = 250;
    }

    public override void Oninteract()
    {
        InteractText = "Press E to Interact";
        player = GameObject.FindGameObjectWithTag("Player").gameObject;
        regen();

    }
    public void regen()
    {
        Collider[] player_InRange = Physics.OverlapSphere(this.transform.position, radius);
        foreach(Collider col in player_InRange)
        {
            //col.gameObject.GetComponent<EntityStats>().playerWater += regen_Rate;
        }

    }
}
