using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public PlayerStats stats;
    public float groundDist;

    public LayerMask groundLayers;
    public PlayerInventory inventory;

    public BoxCollider col;

    public Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<BoxCollider>();
        stats = GetComponentInChildren<PlayerStats>();
        groundDist = col.bounds.extents.y;
        inventory = GetComponent<PlayerInventory>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 playerMovement = new Vector3(horizontal, 0f, vertical) * stats.entitySpeed * Time.deltaTime;
        transform.Translate(playerMovement, Space.Self);

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded() ) {
           rb.velocity = Vector3.up * stats.jumpVelocity;
        }
        if (rb.velocity.y < 0) {
            rb.velocity += Vector3.up * Physics.gravity.y * (stats.fallMultiplier - 1) * Time.deltaTime;
        }
    }

    private bool IsGrounded()
    {
       return Physics.Raycast(transform.position, -Vector3.up, groundDist - 0.605f);
    }
}
