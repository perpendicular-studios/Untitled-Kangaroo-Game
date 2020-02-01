using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class KangarooStats : MonoBehaviour
{

    public float Health;
    public float HealthOverTime;

    public Slider HealthBar;

    Rigidbody myBody;

    // Start is called before the first frame update
    private void Start()
    {
        myBody = GetComponent<Rigidbody>();
        HealthBar.maxValue = Health;


        updateUI();
    }

    // Update is called once per frame
    private void Update()
    {
        ValueChanges();

    }

    private void ValueChanges() {

        if (Health < 0) {
            Debug.Log("nibba ded");
        }
    
    
    }

    private void updateUI() {

        Health = Mathf.Clamp(Health, 0, 100);

        HealthBar.value = Health;
    
    }

    public void TakeDamage(float num) {

        Health -= num;
        if (Health < 0) {
            Health = 0;
        }
        updateUI();

    }


}
