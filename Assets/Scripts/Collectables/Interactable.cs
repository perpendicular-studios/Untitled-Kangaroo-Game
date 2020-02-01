using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public Transform target;
    public float radius = 3f;

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }

    public virtual void Interact()
    {
        // Meant to be overriden
        Debug.Log("Interacting with " + transform.name);
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player" && gameObject.tag == "Collectibles")
        {
            Debug.Log(collider);
            Destroy(gameObject);
        }
    }
    
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        if (distance <= radius)
        {
            Interact();
        }
    }
}
