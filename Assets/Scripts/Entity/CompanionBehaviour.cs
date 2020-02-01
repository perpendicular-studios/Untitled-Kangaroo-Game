using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompanionBehaviour : MonoBehaviour
{
    public GameObject player;
    float mSpeed = 5.0f;

    float distance = 1.0f;

    float epsilon = 4.0f;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(player.transform.position);

        distance = Vector3.Distance(transform.position, player.transform.position);
        
        if (distance > epsilon) {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, mSpeed*Time.deltaTime);
        }
    }
}
