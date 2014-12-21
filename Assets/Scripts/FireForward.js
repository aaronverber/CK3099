#pragma strict

public var bullet: GameObject;

function Update () {
	if(Input.GetKeyDown("up")){
		Instantiate(bullet, transform.position, transform.rotation);
		Debug.Log(Quaternion.identity);
	};
}