using UnityEngine;
using System.Collections;

public class EnemyBehavior : MonoBehaviour {

	public int hullHealth = 20;
	public GameObject shieldArray;
	public Color transparent = new Color (1f, 1f, 1f, 0.5f);
	int[] rotationArray = new int[] { 0, 60, 120, 180, 240, 300};

	void Start(){
		foreach(int shieldRotation in rotationArray){
			GameObject newShield = Instantiate(shieldArray, transform.position, Quaternion.Euler(0, 0, shieldRotation)) as GameObject;
			newShield.transform.parent = gameObject.transform;
		}
	}

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