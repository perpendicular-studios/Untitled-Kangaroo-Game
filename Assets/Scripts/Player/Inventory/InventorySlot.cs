using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Item item;
    public Text displayText;
    public Image displayImage;

    void Start() {}

    void Update()
    {
        if(item)
        {
            displayText.text = item.itemName;
            displayImage.sprite = item.icon;
        }       
        else
        {
            displayText.text = "";
            displayImage.sprite = null;
        }
    }
}
