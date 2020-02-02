using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{

    private List<Item> playerItems;

    public int Count { get { return playerItems.Count; } }


    public void Start()
    {
        playerItems = new List<Item>();
        for(int i = 0; i < 10; i++) {
            playerItems.Add(null);
            Debug.Log(Count);
        }
    }

    public Item GetItemById(int id) {
        return playerItems[id];
    }
    public bool AddItem(Item item)
    {
        int index = item.id;
        Debug.Log(item.id);
        Item inventoryItem = playerItems[index];

        if (inventoryItem != null)
        {
            if (playerItems[index].stackSize > 0)
            {
                int currentStackSize = playerItems[index].stackSize;
                int itemToAddStackSize = item.stackSize;

                if (currentStackSize + itemToAddStackSize < Constants.MAX_ITEM_STACK_SIZE)
                {
                    playerItems[index].stackSize += itemToAddStackSize;
                    return true;
                }
            }
        }
        else
        {
            Debug.Log(item.id);
            playerItems[index] = item;
            return true;
        }
        
        return false;
    }

    public bool RemoveItem(Item item)
    {
        int index = item.id;
        if (Count != 0)
        {
            if (playerItems[index].stackSize > 0)
            {
                int currentStackSize = playerItems[index].stackSize;
                int itemToRemoveStackSize = item.stackSize;

                int newStackSize = currentStackSize - itemToRemoveStackSize;
                if (newStackSize > 0)
                {
                    playerItems[index].stackSize = newStackSize;
                    if (playerItems[index].stackSize == 0)
                    {
                        // If after removing item, stack size is 0, remove from list.
                        playerItems.Remove(item);
                    }
                    return true;
                }
            }
        }
        return false;
    }
}
