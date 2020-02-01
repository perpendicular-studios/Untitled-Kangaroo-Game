using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : ScriptableObject
{
    public string itemName;
    public Sprite icon;
    public int id;
    public int stackSize = 0;

    public virtual void Use() {}



}
