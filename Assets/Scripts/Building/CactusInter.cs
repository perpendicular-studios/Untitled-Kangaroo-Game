using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusInter : Cactii
{
    private bool cIsUsed = false;

    public override void onInteract()
    {
        InteractText = "Press E to Interact";
        cIsUsed = !cIsUsed;

    }



}
