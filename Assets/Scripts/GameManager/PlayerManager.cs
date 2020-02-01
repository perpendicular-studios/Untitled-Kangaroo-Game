using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public Interactable focus;
    // Start is called before the first frame update
    #region Singleton

    public static PlayerManager instance;

    void Awake() {
        instance = this;
    }

    #endregion


    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            Interactable interactable = GetComponent<Interactable>();
            if (interactable != null) {
                Focus = interactable;
            } else {
                Focus = null;
            }
        }
    }

    public Interactable Focus
    {
        get { return focus; }
        set { focus = value; }
    }

    public GameObject player;
}
