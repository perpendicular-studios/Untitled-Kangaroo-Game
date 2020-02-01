using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractBuildings : BrokenFireStation
{
    private bool bIsUsed = false;

    public override void onInteract()
    {
        InteractText = "Press E to Interact";
        bIsUsed = !bIsUsed;
    }
}
