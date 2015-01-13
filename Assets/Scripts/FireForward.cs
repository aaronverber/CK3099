using UnityEngine;
using System.Collections;

public class FireForward : MonoBehaviour {

	public GameObject bullet;
		
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("up")){
			Instantiate(bullet, transform.position, transform.rotation);
			Physics2D.IgnoreCollision(bullet.collider2D, collider2D);
		}
	}
}
