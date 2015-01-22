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

					if (canActivate == true) {
						setOuterShieldArrayActive ();
					}
					activationCycle += Time.deltaTime;
					if (activationCycle >= 0.1f) {
						canActivate = true;
						activationCycle = 0.0f;
					} else {
						canActivate = false;
					}
				}
			}
		}
	}
	void setOuterShieldArrayActive(){
		foreach (ShieldBar shield in shieldBars) {
			if(shield.gameObject.name == "outerShieldBar"){
				shield.gameObject.SetActive(true);
				Debug.Log ("success");
			}		
		}
	}
}
