using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //public is used to make the variable available while playing
    public Rigidbody rb;            //taking rigidbody component in code and giving it name rb
    public float forwardmove = 2000f;    //taking variable with name forwardmove of default value 2000, f is used to represent float t unity 
    public float sidemove = 500f;
    public float jump = 3000f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

      if (Input.GetKey("d"))    //Input.GetKey() method gets the key pressed by user. if the condition in if is true the code will be executed
        {
            rb.AddForce(sidemove * Time.deltaTime, 0, 0);  // variable is used so that the value that variavle carries becomes the value of force

        }

      if (Input.GetKey("a"))
        {
            rb.AddForce(-sidemove * Time.deltaTime, 0, 0 , ForceMode.VelocityChange);
        }

      if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardmove * Time.deltaTime, ForceMode.VelocityChange);
        }

      if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -forwardmove * Time.deltaTime, ForceMode.VelocityChange);
        }

      if (Input.GetKey("space"))
        {
            rb.AddForce(0, jump * Time.deltaTime, 0, ForceMode.VelocityChange);      //ForceMode.VelocityChange changes the dirn of velocity directly
        }
    }
}
