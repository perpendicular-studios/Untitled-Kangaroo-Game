using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image currentHealthbar;
    private float currentHealth = 2;
    private float maxHealth = 150;
    private float ratio;


    private void Start()
    {
        UpdateHealthbar();
    }

    private void UpdateHealthbar()
    {
        ratio = currentHealth / maxHealth;
        currentHealthbar.rectTransform.localScale = new Vector3(ratio, 1, 1);
    }

    private void TakeDamage(float damage)
    {

    }

    private void HealDamage(float heal)
    {

    }
}
