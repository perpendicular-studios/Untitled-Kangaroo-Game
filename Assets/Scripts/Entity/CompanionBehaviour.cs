using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompanionBehaviour : MonoBehaviour
{
    public GameObject player;
    public Transform mTarget;
    float mSpeed = 10.0f;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.LookAt(player.transform.position);

        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, 0.1f*Time.deltaTime);
    }
}
