using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cactii : MonoBehaviour
{
    public Material[] material;
    public int Health;
    public Renderer rend;
    public CapsuleCollider meshCollider;

    public string InteractText = "Press E to Get Item";

    // set up the cactus
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
        meshCollider = GetComponent<CapsuleCollider>();
        meshCollider.enabled = true;
    }

    public virtual void onInteract()
    {
    }

}
