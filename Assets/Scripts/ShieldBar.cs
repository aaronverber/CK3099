using UnityEngine;
using System.Collections;

public class ShieldBar : MonoBehaviour {

	public float totalShieldHealth = 20;
	private float shieldHealth;
	private float damageDealt;
	private float hueShiftBase;
	private float hueShiftTotal;
	private float satShiftBase;
	bool chargeNow;
	float rechargeCylce;

	void Start(){
		shieldHealth = totalShieldHealth;
	}

	void Update(){
		if (shieldHealth >= totalShieldHealth) {
			return;
		} else {
			if (chargeNow == true) {
				rechargeShieldHealth (1);
			}
			rechargeCylce += Time.deltaTime;
			if (rechargeCylce >= 0.4f) {
				chargeNow = true;
				rechargeCylce = 0.0f;
			} else {
				chargeNow = false;
			}
		}
	}
	
	void OnTriggerEnter2D(Collider2D other){
		damageDealt = other.gameObject.GetComponent<Bullet> ().damageDealt;
		if (other.gameObject.tag == "FriendlyProjectile") {
				Destroy (other.gameObject);
				drainShieldHealth (damageDealt);
		}
	}

	void shiftShieldColor (float amount){
		hueShiftBase = (amount / totalShieldHealth) * 150;
		satShiftBase = 2;
		hueShiftTotal = hueShiftBase * ((totalShieldHealth - shieldHealth) / amount);
		Debug.Log (hueShiftTotal);
		renderer.material.SetFloat("_HueShift", hueShiftTotal);
		renderer.material.SetFloat("_Sat", satShiftBase);
	}

	void drainShieldHealth(float damage){
		if (shieldHealth > 1) {
			shieldHealth -= damage;
			shiftShieldColor(damage);
		}
		else{
			Destroy (gameObject);
		}
	}

	void rechargeShieldHealth(float rechargeRate){
		shieldHealth += rechargeRate;
		shiftShieldColor(-rechargeRate);
	}
}