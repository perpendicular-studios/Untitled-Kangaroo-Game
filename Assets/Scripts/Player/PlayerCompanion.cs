using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCompanion : MonoBehaviour
{
    public PlayerStats stats;

    GameObject referenceObject;

    CompanionBehaviour referenceScript;

    int counter;

    // Start is called before the first frame update
    void Start()
    {
        stats = GetComponentInChildren<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {

        Collider[] hits = Physics.OverlapSphere(transform.position, 2);
        foreach (Collider hit in hits) 
        {
            
            if (hit.tag == "Companion" && stats.currentCompanions < stats.maxCompanions) 
            {
                referenceObject = hit.gameObject;

                if (hit.gameObject.name == "Health Roo(Clone)")
                {
                    referenceScript = referenceObject.GetComponent<HealthRooBehaviour>();
                    if (!(referenceScript.hasMasterGetter())) 
                        {
                            referenceScript.OnRescue();
                            stats.CompanionList[counter] = referenceObject;
                            counter++;
                            stats.currentCompanions += 1;
                        }

                } else if (hit.gameObject.name == "Speed Roo(Clone)")
                {
                    referenceScript = referenceObject.GetComponent<SpeedRooBehaviour>();
                    if (!(referenceScript.hasMasterGetter())) 
                        {
                            referenceScript.OnRescue();
                            stats.CompanionList[counter] = referenceObject;
                            counter++;
                            stats.currentCompanions += 1;
                        }

                }
                
            }
        }
    }
}
