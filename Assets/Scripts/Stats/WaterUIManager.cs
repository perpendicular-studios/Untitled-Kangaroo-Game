using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterUIManager : MonoBehaviour
{
    public PlayerStats playerStats;
    public Text waterDisplay;

    public void Update()
    {
        waterDisplay.text = $"{playerStats.playerWater}";
    }

}
