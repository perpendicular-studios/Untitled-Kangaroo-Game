using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyStats : EntityStats
{
    
    public GameObject TapePrefab;

    void Awake()
    {
        maxHealth = 80;
    }

    public int MaxHealth
    {
        get { return maxHealth; }
        set { maxHealth = value; }
    }

    public override void Die()
    {
        Debug.Log("TAPE GENERATING!");
        // Add ragdoll effect

        // drop = ScriptableObject.CreateInstance("Tape");
        // Destroy(gameObject);
        
        Instantiate(TapePrefab, transform.position + Vector3.up, Quaternion.FromToRotation(Vector3.up, Vector3.forward));
        Destroy(gameObject);
    }
}
