using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public float thrust = 10;
	private GameObject player;
	private PlayerMovement playerMovement;
	private TargetEnemies te;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
		playerMovement = player.GetComponent<PlayerMovement>();
		te = player.GetComponent<TargetEnemies> ();

		Vector2 dir = (te.selectedTarget.transform.position - transform.position).normalized * thrust;
		//dir = te.selectedTarget.InverseTransformDirection (dir);
		//float angle = Mathf.Atan2(dir.y, dir.x);

		//float playerVelX = player.rigidbody2D.velocity.x;
		//float playerVelY = player.rigidbody2D.velocity.y;
		
		//float vx = (Mathf.Sin(angle) * thrust) + playerVelX;
		//float vy = (Mathf.Cos(angle) * thrust) + playerVelY;
		
		//Vector2 bulletVelocity = new Vector2(vx, vy);
		rigidbody2D.velocity = dir;
	
	}
	
	// Update is called once per frame
	void OnBecameInvisible () {
		Destroy(gameObject);
	}
}
