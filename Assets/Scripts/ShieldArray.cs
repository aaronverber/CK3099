using UnityEngine;
using System.Collections;

public class ShieldArray : MonoBehaviour {
	private bool canActivate;
	private float activationCycle;
	private GameObject iSB;
	private ShieldBar iSBScript;
	private GameObject oSB;
	private ShieldBar oSBScript;
	
	// Use this for initialization
	void Start () {
		foreach (Transform child in transform) {
			if(child.gameObject.name == "innerShieldBar"){
				iSB = child.gameObject;
				iSBScript = iSB.gameObject.GetComponent<ShieldBar>();
			}
			if(child.gameObject.name == "outerShieldBar"){
				oSB = child.gameObject;
				oSBScript = oSB.gameObject.GetComponent<ShieldBar>();
			}
		}
	}

	// Update is called once per frame
	void Update () {
		if ((iSBScript.shieldHealth >= iSBScript.totalShieldHealth) ) {
			if (canActivate == true) {
				oSB.gameObject.SetActive(true);
			}
			activationCycle += Time.deltaTime;
			if (activationCycle >= 1.5f) {
				canActivate = true;
				activationCycle = 0.0f;
			} else {
				canActivate = false;
			}
		}
		if (iSB.gameObject.activeInHierarchy == false) {
			if (canActivate == true) {
				iSB.gameObject.SetActive(true);
			}
			activationCycle += Time.deltaTime;
			if (activationCycle >= 2.5f) {
				canActivate = true;
				activationCycle = 0.0f;
			} else {
				canActivate = false;
			}	
		}
	}
}