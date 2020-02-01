using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cactii : MonoBehaviour
{
    public Material[] material;
    public int Health;
    Renderer rend;

    public string Name;

    public string InteractText = "Press E to Get Item";

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetKeyDown("e"))
        {
            rend.enabled = false;
        }

    }
    public virtual void onInteract()
    {

    }
}
