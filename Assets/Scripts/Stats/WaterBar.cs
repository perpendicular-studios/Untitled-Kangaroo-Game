using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterBar : MonoBehaviour
{
    public Image currentWaterbar;
    public PlayerStats stats;
    private float ratio;


    public void FixedUpdate()
    {
        ratio =  ((float)stats.playerWater / (float)stats.maxWater);
        currentWaterbar.rectTransform.localScale = new Vector3(ratio, 1, 1);
    }

}
