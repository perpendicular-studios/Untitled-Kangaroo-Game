using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireManager : MonoBehaviour
{
    public GameObject treeGenerator;
    public float secondsPerTreeUpdate = 60;
    public float treesSetOnFirePerUpdate = 10;

    private float actionTime;
    private ParticleSystem[] treeFires;

    void Start()
    {
        treeFires = treeGenerator.GetComponentsInChildren<ParticleSystem>();
    }

    void Update()
    {
        if (actionTime > secondsPerTreeUpdate) {
            for (int i = 0; i < treeFires.Length; i++)
            {
                if (treeFires[i] != null)
                {
                    treeFires[i].Play();
                }
            }
            actionTime = 0;
        }
        actionTime += Time.deltaTime;
    }
}
