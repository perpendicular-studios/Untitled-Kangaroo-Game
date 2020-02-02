using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingStats : MonoBehaviour
{
    [Header("Building Stats")]
    public int maxHealth;
    public int healthThreshold;
    Material[] materials;

    protected Renderer rend;

    public string InteractText = "Press E to Interact";

    public PlayerStats stats;

    public int currentHealth
    {
        get;
        private set;
    }

    void Start()
    {
        stats = GameObject.FindGameObjectWithTag("PlayerStats").GetComponent<PlayerStats>();
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log(currentHealth);
        if(currentHealth <= 0)
        {
            Destroyed();
        }
    }

    public virtual void Oninteract()
    {
    }


    public virtual void Destroyed()
    {
        Debug.Log(transform.name + "poof ...");
        rend.enabled = false;
    }
}
