using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance;
    public PlayerMovement player;
    public boolean scammed = true;
    void Awake() {
        instance = this;
    }



    void Update()
    {
        if (player.stats.playerWater > 0)
        {
            if (Input.GetKey(KeyCode.R))
            {
                player.extinguishBeam.gameObject.SetActive(true);
            }
            else
            {
                player.extinguishBeam.gameObject.SetActive(false);
            }
        }
        else
        {
            player.extinguishBeam.gameObject.SetActive(false);
        }
    }

}
