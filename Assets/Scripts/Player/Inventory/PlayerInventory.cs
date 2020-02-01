using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{

    public List<Item> PlayerItems { get { return playerItems; } }
    private List<Item> playerItems;

    public int Count { get { return playerItems.Count; } }

    public void Start()
    {
        playerItems = new List<Item>();
    }

    public bool AddItem(Item item)
    {
        int index = item.id;
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
