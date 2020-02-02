using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    
    public Item item;

    public Text displayText;
    public Text stackSizeText;

    public Image displayImage;

    public int slotType;

    void Start() {}

    void Update()
    {

        if(item)
        {
            Debug.Log(item);
            displayText.text = item.itemName;
            stackSizeText.text = $"{item.stackSize}";
            displayImage.sprite = item.icon;
        } 
        else
        {
            displayText.text = "";
            stackSizeText.text = "";
            displayImage.sprite = null;
        }
        
    }
}
