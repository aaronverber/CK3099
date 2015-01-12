using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public GameObject cameraPos;
	public GameObject playerPos;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 cameraAdjustment = new Vector3 (0, 0, -20);
		cameraPos.transform.position = playerPos.transform.position + cameraAdjustment;
	}
}
