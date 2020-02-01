using UnityEngine;

public class BrokenFireStation : MonoBehaviour
{

    public Material[] material;
    public bool material1;
    public bool material2;

    Renderer rend;

    private PlayerMovement player;
    private Vector3 building_Position;

    public int Regen_Rate = 10;
    public int Health;
    public int radius;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];

        material1 = false;
        material2 = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("e") && Health >= 150)
        {
            rend.sharedMaterial = material[1];
            fixed_FireStation();

        }
    }


   void fixed_FireStation()
    {
        //player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>.
        refill();
    }


   void refill()
    {
        Collider[] player_In_Range = Physics.OverlapSphere(this.building_Position, radius);



    }
}
