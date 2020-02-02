using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompanionBehaviour : MonoBehaviour
{
    public GameObject player;

    public PlayerStats stats;
    float mSpeed = 3.0f;

    float distance = 1.0f;

    float epsilon = 4.0f;

    protected bool hasMaster = false;

    public bool hasMasterGetter () {
        return hasMaster;
    }


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        stats = GameObject.FindGameObjectWithTag("PlayerStats").GetComponent<PlayerStats>();
    }

    public virtual void OnRescue() {
        if (!hasMaster) {
            hasMaster = !hasMaster;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(player.transform.position);
        if (hasMaster) {
            distance = Vector3.Distance(transform.position, player.transform.position);
            
            if (distance > epsilon) {
                transform.position = Vector3.MoveTowards(transform.position, player.transform.position, mSpeed*Time.deltaTime);
            }
        }
    }
}
