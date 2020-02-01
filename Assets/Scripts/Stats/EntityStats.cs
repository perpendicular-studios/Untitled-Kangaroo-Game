using System.Collections;	
using System.Collections.Generic;	
using UnityEngine;	

public class EntityStats : MonoBehaviour	
{	
    [Header("Entity Stats")]
    public int maxHealth;
    public int currentHealth
    {	
        get;	
        private set;	
    }	

    [Header("Entity Movement")]
    public float entitySpeed;

    void Awake()	
    {	
        currentHealth = maxHealth;	
    }	

    public void TakeDamage(int damage)	
    {	
        currentHealth -= damage;	
        if (currentHealth <= 0)	
        {	
            Die();	
        }	
    }	

    public virtual void Die()	
    {	
        // Die in some way	
        Debug.Log(transform.name + " died...");	
    }	
}	
