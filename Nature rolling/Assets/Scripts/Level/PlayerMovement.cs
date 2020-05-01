using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float force = 200f;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("w")) 
        {
            rb.AddForce(0, 0, force * Time.fixedDeltaTime);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-force * Time.fixedDeltaTime, 0, 0);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -force * Time.fixedDeltaTime);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(force * Time.fixedDeltaTime, 0, 0);
        }
    }
}
