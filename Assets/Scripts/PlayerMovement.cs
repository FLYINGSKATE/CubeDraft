using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public Rigidbody rb;
    public float ForwardForce=1000f;
    public float SideWayForce = 6f;
    
	// Use this for initialization
	
	
	// Update is called once per frame
	void FixedUpdate () {
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(SideWayForce, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-SideWayForce, 0, 0,ForceMode.VelocityChange);
        }
        if (rb.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

	}

    public void MoveLeft()
    {
        rb.AddForce(-SideWayForce+(-3), 0, 0, ForceMode.VelocityChange);
    }
    public void MoveRight()
    {
        rb.AddForce(SideWayForce+3, 0, 0, ForceMode.VelocityChange);
    }
    public void setVelocityZero()
    {
        rb.velocity = Vector2.zero;
    }
}
