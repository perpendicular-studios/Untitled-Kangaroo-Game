using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image currentHealthbar;
    public PlayerStats stats;
    private float ratio;



    public void FixedUpdate()
    {
        ratio =  ((float)stats.currentHealth / (float)stats.maxHealth);
        currentHealthbar.rectTransform.localScale = new Vector3(ratio, 1, 1);
    }

}
