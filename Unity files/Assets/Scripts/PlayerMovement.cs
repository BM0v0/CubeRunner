using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float forwardforce = 2000f;
    public float sidewaysForce = 500f;
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        // Add a forward force
        rb.AddForce(0, 0, forwardforce * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("w"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 5, 0, 0);
        }
        if(rb.position.y < -5f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
