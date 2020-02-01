using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{

    private Cactii mInteractCac;
    private BrokenFireStation mInteractFire;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            mInteractFire.onInteractAnimation();
        }
        if (Input.GetKeyDown("f"))
        {
            mInteractCac.OnInteractAnimation();
        }



    }

    public void Interact_With_Item()
    {

    }
}
