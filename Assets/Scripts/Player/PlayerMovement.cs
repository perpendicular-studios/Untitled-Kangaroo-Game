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
         if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
         {
            rb.AddForce(Vector3.up * stats.jumpForce, ForceMode.Impulse);
         }
    }


    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(horizontal * stats.playerSpeed * Time.deltaTime, 0, vertical * stats.playerSpeed * Time.deltaTime);
    }

    private bool IsGrounded()
    {
       return Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x, col.bounds.min.y, 
       col.bounds.center.z), col.radius * .9f, groundLayers);
    }
}
