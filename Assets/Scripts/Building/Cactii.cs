using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cactii : MonoBehaviour
{
    public Material[] material;
    public int Health;
    Renderer rend;

    public string Name;
    public Sprite Image;

    public string InteractText = "Press E to Get Item";

    // set up the cactus
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }

    void OnInteractAnimation()
        //makes the cactus dissapear
    {
        rend.enabled = false;
    }
    public virtual void onInteract()
    {
    }

}
