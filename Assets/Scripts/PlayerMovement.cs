using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float thrust = 300.0f;
	public float rotationSpeed = 40.0f;
	public float accel = 0;
	public float rotation = 0;
	public float radRotation = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	    accel = Input.GetAxis("Vertical") * thrust;
        rotation = Input.GetAxis("Horizontal") * -(rotationSpeed);
	    radRotation = (rigidbody2D.rotation * (Mathf.PI / 180));

        float vx = -accel * (Mathf.Sin(radRotation));
	    float vy = accel * (Mathf.Cos(radRotation));

		Vector2 forceDirection = new Vector2 (vx, vy);
	    rigidbody2D.AddForce(forceDirection);
	    rigidbody2D.MoveRotation(rigidbody2D.rotation + rotation * Time.deltaTime);	
	
	    if(Input.GetButton("Fire1")){
			Vector2 forceVec = new Vector2(-rigidbody2D.velocity.normalized.x * thrust, -rigidbody2D.velocity.normalized.y * thrust);
		    rigidbody2D.AddForce(forceVec,ForceMode2D.Force);
	    };
	}
}