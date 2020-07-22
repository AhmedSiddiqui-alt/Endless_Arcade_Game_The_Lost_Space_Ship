using UnityEngine;

public class spaceShipMovement : MonoBehaviour {
    //Reference to rigidbody component called rb
    public Rigidbody rb;
    public float forwardForce=2000;
    public float leftrightForce=500;
	//We are using FixedUpdate as because it deals with physics problems 
	void FixedUpdate () {
        rb.AddForce(0,0,forwardForce*Time.deltaTime);
        if(Input.GetKey("d"))
        {
            rb.AddForce(leftrightForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        else if(Input.GetKey("a"))
        {
            rb.AddForce(-leftrightForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y<-1f)
        {
            FindObjectOfType<spaceshipManager>().EndGame();
        }
	}
}
