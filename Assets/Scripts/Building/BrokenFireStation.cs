using UnityEngine;

public class BrokenFireStation : MonoBehaviour
{

    public Material[] material;
    public bool material1;

    public int Health;
    public Renderer rend;
    public CapsuleCollider meshCollider;

    public string Name;
    public Sprite Image;

    public string InteractText = "Press E to Get Item";

    // set up the cactus
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
        meshCollider = GetComponent<CapsuleCollider>();
        meshCollider.enabled = true;
        material1 = false;
}

    public virtual void onInteract()
    {
    }


}
