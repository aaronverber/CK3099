using UnityEngine;
using System.Collections;

public class EnemyBehavior : MonoBehaviour {

	public Color transparent = new Color (1f, 1f, 1f, 0.5f);

	void OnTriggerEnter2D(Collider2D other){
		Destroy(other.gameObject);
		this.GetComponent<SpriteRenderer>().color = transparent;
		Debug.Log ("hit!");
	}
}	