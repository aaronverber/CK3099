using UnityEngine;
using System.Collections;

public class FireForward : MonoBehaviour {

	public GameObject bullet;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("up")){
			Instantiate(bullet, transform.position, transform.rotation);
		}
	}
}
