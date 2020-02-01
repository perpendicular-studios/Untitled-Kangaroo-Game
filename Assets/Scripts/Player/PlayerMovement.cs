using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public PlayerStats stats;

    

    public LayerMask groundLayers;

    public CapsuleCollider col;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<CapsuleCollider>();
        stats = GetComponentInChildren<PlayerStats>();
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded()) {
           GetComponent<Rigidbody>().velocity = Vector3.up * stats.jumpVelocity;
        }
        if (rb.velocity.y < 0) {
            rb.velocity += Vector3.up * Physics.gravity.y * (stats.fallMultiplier - 1) * Time.deltaTime;
        }
    }


    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 playerMovement = new Vector3(horizontal, 0f, vertical) * stats.entitySpeed * Time.deltaTime;
        transform.Translate(playerMovement, Space.Self);
        // transform.position = transform.position + new Vector3(horizontal * stats.entitySpeed * Time.deltaTime, 0, vertical * stats.entitySpeed * Time.deltaTime);
    }

    private bool IsGrounded()
    {
       return Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x, col.bounds.min.y, 
       col.bounds.center.z), col.radius * .8f, groundLayers);
    }
}
