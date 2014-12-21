#pragma strict

	var cameraPos : GameObject;
	var playerPos : GameObject;

function Start () {
}

function Update () {
	cameraPos.transform.position = playerPos.transform.position + Vector3(0,0,-20);
}