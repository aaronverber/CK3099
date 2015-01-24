using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float thrust = 300.0f;
	public float rotationSpeed = 40.0f;
	private float accel = 0;
	private float rotation = 0;
	private float radRotation = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

	    accel = Input.GetAxis("Vertical") * thrust;
        rotation = Input.GetAxis("Horizontal") * -(rotationSpeed);
	    radRotation = (rigidbody2D.rotation * (Mathf.PI / 180));

	    rigidbody2D.AddRelativeForce(Vector2.up * accel);
	    rigidbody2D.MoveRotation(rigidbody2D.rotation + rotation * Time.deltaTime);	
	
	    if(Input.GetButton("Fire1")){
			Vector2 forceVec = new Vector2(-rigidbody2D.velocity.normalized.x * thrust, -rigidbody2D.velocity.normalized.y * thrust);
		    rigidbody2D.AddForce(forceVec,ForceMode2D.Force);
	    };

		if(Input.GetKey (KeyCode.Q)){
			rigidbody2D.AddRelativeForce(Vector2.right * -thrust);
		}

		if(Input.GetKey (KeyCode.E)){
			rigidbody2D.AddRelativeForce(Vector2.right * thrust);
		}
	}
}