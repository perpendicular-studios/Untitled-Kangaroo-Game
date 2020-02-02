using System.Collections;	
using System.Collections.Generic;	
using UnityEngine;	

public class EntityStats : MonoBehaviour	
{	
    [Header("Entity Stats")]
    public int maxHealth;
    public int currentHealth;
    public int dealDamage;

    [Header("Entity Movement")]
    public float entitySpeed;

    void Start()	
    {	
        currentHealth = maxHealth;
    }	

    public void TakeDamage(int damage)	
    {	
        currentHealth -= damage;	
        Debug.Log(currentHealth);
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
