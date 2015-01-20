using UnityEngine;
using System.Collections;

public class ShieldBar : MonoBehaviour {

	public float totalShieldHealth = 20;
	private float shieldHealth;
	private float damageDealt;
	private float hueShiftBase;
	private float hueShiftTotal;
	private float satShiftBase;

	void Start(){
		shieldHealth = totalShieldHealth;
	}

	void OnTriggerEnter2D(Collider2D other){
		damageDealt = other.gameObject.GetComponent<Bullet> ().damageDealt;
		if (other.gameObject.tag == "FriendlyProjectile") {
				Destroy (other.gameObject);
				drainShieldHealth (damageDealt);
		}
	}

	void drainShieldHealth(float damage){
		hueShiftBase = (damage / totalShieldHealth) * 150;
		satShiftBase = 2;
		if (shieldHealth > 1) {
			shieldHealth -= damage;
			hueShiftTotal = hueShiftBase * ((totalShieldHealth - shieldHealth) / damage);
			Debug.Log (hueShiftTotal);
			renderer.material.SetFloat("_HueShift", hueShiftTotal);
			renderer.material.SetFloat("_Sat", satShiftBase);
		}
		else{
			Destroy (gameObject);
		}
	}
}