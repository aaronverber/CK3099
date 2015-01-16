using UnityEngine;
using System.Collections;

public class FireForward : MonoBehaviour {

	public GameObject bullet;
	TargetEnemies te;
	float distanceToEnemy;

	void Start() {
		te = gameObject.GetComponent<TargetEnemies>();
	}

	// Update is called once per frame

	void Update () {
		if (te.selectedTarget == null) {
			return;
		} else {

			distanceToEnemy = Vector2.Distance (transform.position, te.selectedTarget.transform.position);
		}
		if (distanceToEnemy <= 5.0) {
			FireAtTarget ();
		}
	}

	void FireAtTarget(){

		Instantiate(bullet, transform.position, transform.rotation);
		Physics2D.IgnoreCollision(bullet.collider2D, collider2D);
	}
}
