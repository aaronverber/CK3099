using UnityEngine;
using System.Collections;

public class EnemyBehavior : MonoBehaviour {

	public int hullHealth = 20;
	public Color transparent = new Color (1f, 1f, 1f, 0.5f);

	void OnTriggerEnter2D(Collider2D other){
		if ((other.gameObject.tag == "FriendlyProjectile") && (hullHealth > 1)){
			Destroy (other.gameObject);
			hullHealth -= 1;
		}
		if ((other.gameObject.tag == "FriendlyProjectile") && (hullHealth <= 1)) {
			Destroy (other.gameObject);
			Destroy (gameObject);
		}
	}
}	