using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public float thrust = 10;
	public float damageDealt = 1;
	private GameObject player;
	private PlayerMovement playerMovement;
	private TargetEnemies te;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
		playerMovement = player.GetComponent<PlayerMovement>();
		te = player.GetComponent<TargetEnemies> ();

		Vector2 dir = (te.selectedTarget.transform.position - transform.position).normalized * thrust;
		rigidbody2D.velocity = dir;
	}
	
	// Update is called once per frame
	void OnBecameInvisible () {
		Destroy(gameObject);
	}
}
