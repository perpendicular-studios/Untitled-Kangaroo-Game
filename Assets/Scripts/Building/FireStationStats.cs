using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireStationStats : BuildingStats
{
    public BrokenFireStation BrokeFS;
    public bool material1;
    public Material material;

    private void Awake()
    {
        maxHealth = 100;
        BrokeFS = GetComponentInParent<BrokenFireStation>();
        material1 = false;
        //BrokeFS.material.
    }
    void Update()
    {

        Collider[] hits = Physics.OverlapSphere(transform.position, 2);
        foreach (Collider hit in hits)
        {

            //Debug.Log("reeee");
            if (Input.GetKeyDown("e") && (hit.gameObject.name == "Player") && material1 == true)
            {
                //Debug.Log("test");
                stats.playerWater += 15;
                BrokeFS.rend.enabled = true;
                /*BrokeFS.meshCollider.sharedMaterial;*/
            }


        }
    }
}
