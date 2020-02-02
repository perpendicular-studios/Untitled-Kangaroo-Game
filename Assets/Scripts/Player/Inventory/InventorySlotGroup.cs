using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlotGroup : MonoBehaviour
{
    [SerializeField]
    public InventorySlot centerSlot;

    [SerializeField]
    public PlayerInventory playerInventory;

    private int currentIndex = 0;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.O) && currentIndex > 0)
        {
            currentIndex--;
        }

        if(Input.GetKeyDown(KeyCode.P) && currentIndex < playerInventory.Count)
        {
            currentIndex++;
        }
        
        if (playerInventory.Count != 0)
        {
            Item centerItem = playerInventory.GetItemById(currentIndex);
            centerSlot.item = centerItem;
        }
    }
}
