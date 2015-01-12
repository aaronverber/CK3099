#pragma strict

var thrust : float = 5.0;
var rotationSpeed : float = 75.0;
public var accel : float = 0;
public var rotation : float = 0;
public var radRotation : float = 0;

//var velocity: Vector2;

function Start () {

}

function FixedUpdate () {
	accel = Input.GetAxis("Vertical") * thrust;
	rotation = Input.GetAxis("Horizontal") * -(rotationSpeed);
	radRotation = (rigidbody2D.rotation * (Mathf.PI / 180));
	
	var vx = -accel * (Mathf.Sin(radRotation));
	var vy = accel * (Mathf.Cos(radRotation));
	
	rigidbody2D.AddForce(Vector2(vx, vy));
	rigidbody2D.MoveRotation(rigidbody2D.rotation + rotation * Time.deltaTime);	
	
	if(Input.GetButton("Fire1")){
		var forceVec : Vector2 = -rigidbody2D.velocity.normalized * thrust;
		Debug.Log(forceVec);
		rigidbody2D.AddForce(forceVec,ForceMode2D.Force);
	};
}