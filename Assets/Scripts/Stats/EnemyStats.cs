using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyStats : NPCStats
{
    // Start is called before the first frame update
    

    public override void Die()
    {
        base.Die();

        // Add ragdoll effect

        Destroy(gameObject);
    }
}
