using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public float thrust = 10;
	private GameObject player;
	private PlayerMovement playerMovement;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
		playerMovement = GameObject.Find ("Player").GetComponent<PlayerMovement>();

		float radRotation = playerMovement.radRotation;
		float playerVelX = player.rigidbody2D.velocity.x;
		float playerVelY = player.rigidbody2D.velocity.y;
		
		float vx = -(Mathf.Sin(radRotation) * thrust) + playerVelX;
		float vy = (Mathf.Cos(radRotation) * thrust) + playerVelY;
		
		Vector2 bulletVelocity = new Vector2(vx, vy);
		rigidbody2D.velocity = bulletVelocity;
	
	}
	
	// Update is called once per frame
	void OnBecameInvisible () {
		Destroy(gameObject);
	}
}
