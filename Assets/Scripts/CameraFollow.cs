using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public GameObject cameraPos;
	public GameObject playerPos;
	float minFov = 25f;
	float maxFov = 150f;
	float sensitivity = 30f;

	// Update is called once per frame
	void Update () {
		Vector3 cameraAdjustment = new Vector3 (0, 0, -20);
		cameraPos.transform.position = playerPos.transform.position + cameraAdjustment;
		float fov = Camera.main.fieldOfView;
		fov += Input.GetAxis ("Mouse ScrollWheel") * -sensitivity;
		fov = Mathf.Clamp (fov, minFov, maxFov);
		Camera.main.fieldOfView = fov;
		Debug.Log (fov);
		if(Input.GetMouseButtonDown(2)){
			fov = 70;
			Camera.main.fieldOfView = fov;
		}
	}
}