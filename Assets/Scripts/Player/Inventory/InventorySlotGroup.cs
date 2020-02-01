using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlotGroup : MonoBehaviour
{
    [SerializeField]
    public InventorySlot leftSlot;

    [SerializeField]
    public InventorySlot centerSlot;

    [SerializeField]
    public InventorySlot rightSlot;

    [SerializeField]
    public PlayerInventory playerInventory;

    private int currentIndex = 0;

    void Update()
    {
        if (playerInventory.Count != 0)
        {
            Item centerItem = playerInventory.PlayerItems[currentIndex];
            centerSlot.item = centerItem;
            if (currentIndex + 1 < playerInventory.Count)
            {
                rightSlot.item = playerInventory.PlayerItems[currentIndex + 1];
            }

            if (currentIndex - 1 < playerInventory.Count)
            {
                leftSlot.item = playerInventory.PlayerItems[currentIndex - 1];
            }
        }
    }
}
