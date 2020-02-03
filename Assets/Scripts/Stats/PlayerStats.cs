using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : EntityStats  
{
    public int playerWater;
    public int maxWater;
    public float jumpVelocity;
    public float fallMultiplier;

    public int maxCompanions;

    public int currentCompanions
    {	
        get;	
        set;	
    }

    private GameObject[] companionList;

    public GameObject[] CompanionList
    {
        get
        {
            return companionList;
        }
        set
        {
            companionList = value;
        }
    }

    public int sizeOfList() 
    {
        return companionList.Length;
    }

    void Awake()
    {
        maxWater = 300;
        playerWater = 0;
        maxHealth = 100;
        entitySpeed = 5;
        currentCompanions = 0;
        maxCompanions = 2;
        companionList = new GameObject[maxCompanions];
        dealDamage = 5;
        
    }


public override void Die()
    {
        FindObjectOfType<GameOver>().EndGame();
    }
}
