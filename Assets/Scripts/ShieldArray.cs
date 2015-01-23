using UnityEngine;
using System.Collections;

public class ShieldArray : MonoBehaviour {
	private Component[] shieldBars;
	private bool canActivate;
	private float activationCycle;



	// Use this for initialization
	void Start () {
		shieldBars = GetComponentsInChildren<ShieldBar>(true);


	}

	// Update is called once per frame
	void Update () {
		foreach (ShieldBar shield in shieldBars) {
			if (shield.gameObject.name == "innerShieldBar"){
			    if(shield.shieldHealth >= shield.totalShieldHealth) {
					runShieldActivationCycle();
				}
				if(shield.shieldHealth == null){
					runShieldActivationCycle();
				}
			}
		}
	}

	void setShieldArrayActive(){
		foreach (ShieldBar shield in shieldBars) {
			if(shield.gameObject.name == "outerShieldBar"){
				shield.gameObject.SetActive(true);
				Debug.Log ("success");
			}
			if(shield.gameObject.name == "innerShieldBar"){
				if(shield.gameObject.activeInHierarchy == false){
					shield.gameObject.SetActive(true);
				}
			}
		}
	}

	void runShieldActivationCycle(){
		if (canActivate == true) {
			setShieldArrayActive ();
		}
		activationCycle += Time.deltaTime;
		if (activationCycle >= 1.5f) {
			canActivate = true;
			activationCycle = 0.0f;
		} else {
			canActivate = false;
		}
	}
}
