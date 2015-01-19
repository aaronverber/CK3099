using UnityEngine;
using System.Collections;

public class BrakesUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
		animation.Play ("BrakesFlash");
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButton("Fire1")){
			renderer.enabled = true;
		}
		else{
			renderer.enabled = false;
		};
	}
}
