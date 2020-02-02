using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius = 1f;
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Debug.Log(gameObject.tag);
            // gameObject.tag;
			Item item = Resources.Load<Item>("Items/" + gameObject.tag);
            item.stackSize++;
            Debug.Log(item.id);
            PlayerInventory inventory = collider.transform.Find("PlayerInventory").gameObject.GetComponent<PlayerInventory>();
            
            inventory.AddItem(item);
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
