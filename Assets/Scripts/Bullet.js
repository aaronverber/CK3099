#pragma strict

public var thrust : float = 10;

function Start () {

	var player : GameObject = gameObject.Find("Player");
	var playerMovement : PlayerMovement = player.GetComponent(PlayerMovement);
	
	var radRotation = playerMovement.radRotation;
	var playerVelX = player.rigidbody2D.velocity.x;
	var playerVelY = player.rigidbody2D.velocity.y;
	
	var vx = -(Mathf.Sin(radRotation) * thrust) + playerVelX;
	var vy = (Mathf.Cos(radRotation) * thrust) + playerVelY;
	
	rigidbody2D.velocity = (Vector2(vx, vy));

}

function OnBecameInvisible () {
	Destroy(gameObject);
}