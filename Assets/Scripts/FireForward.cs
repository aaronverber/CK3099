using UnityEngine;
using System.Collections;

public class FireForward : MonoBehaviour {

	public GameObject bullet;
	GameObject player;
	TargetEnemies te;
	float distanceToEnemy;
	bool canShoot;
	float reloadTime;

	void Start() {
		player = GameObject.Find("Player");
		te = player.GetComponent<TargetEnemies>();
	}

	// Update is called once per frame

	void Update () {
		if (te.selectedTarget == null) {
			return;
		} else {
			distanceToEnemy = Vector2.Distance (transform.position, te.selectedTarget.transform.position);
		}
		if (distanceToEnemy <= 5.0) {
			if(canShoot == true){
				FireAtTarget ();
			}
			reloadTime += Time.deltaTime;
			if(reloadTime >= 0.4f){
				canShoot = true;
				reloadTime = 0.0f;
			}
			else{
				canShoot = false;
			}
		}
	}

	void FireAtTarget(){
		GameObject newBullet = (GameObject)Instantiate(bullet, transform.position, transform.rotation);
		Physics2D.IgnoreCollision(bullet.collider2D, collider2D);
		audio.Play ();
	}
}