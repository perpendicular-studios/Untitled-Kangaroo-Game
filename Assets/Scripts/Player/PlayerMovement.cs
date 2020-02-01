using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float moveSpeed = 5f;
    public float jumpForce = 20f;
    
    
    // Start is called before the first frame update
    void Start()
    {

    }

    void FixedUpdate()
    {
         if (Input.GetKeyDown(KeyCode.Space))
         {
            rb.AddForce(new Vector3(0, jumpForce * Time.deltaTime, 0), ForceMode.Impulse);
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
}
