using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public LayerMask groundLayers;

    public CapsuleCollider col;

    public float moveSpeed = 5f;
    public float jumpForce = 200f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<CapsuleCollider>();
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(0, 0, 0);

         if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
         {
            rb.AddForce(Vector3.up * jumpForce * Time.deltaTime, ForceMode.Impulse);
         }
    }


    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(horizontal * moveSpeed * Time.deltaTime, 0, vertical * moveSpeed * Time.deltaTime);
       

        Debug.Log(transform.position);
    }

    private bool IsGrounded()
    {
       return Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x, col.bounds.min.y, 
       col.bounds.center.z), col.radius * .9f, groundLayers);
    }
}
