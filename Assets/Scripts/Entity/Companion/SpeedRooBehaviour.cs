using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedRooBehaviour : CompanionBehaviour
{
    int speedMultiplier = 2;
    public override void OnRescue() {
        if (!hasMaster) {
            hasMaster = !hasMaster;
            stats.entitySpeed = stats.entitySpeed*speedMultiplier;
        }
    }
}
