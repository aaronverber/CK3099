#pragma strict

 	var starLayer01 : GameObject;
 	var starLayer02 : GameObject;
 	

function Start () {

	
}

function Update () {
	var viewPos01 : Vector3 = camera.WorldToViewportPoint(starLayer01.transform.position);
	var viewPos02 : Vector3 = camera.WorldToViewportPoint(starLayer02.transform.position);
	Debug.Log(viewPos01.x);
	if(viewPos01.x <= -1.0){
		viewPos01.x = 1.0;
		var newViewPos01Left : Vector3 = camera.ViewportToWorldPoint(viewPos01); 
		starLayer01.transform.position = newViewPos01Left;
	}
	
	else if(viewPos01.x >= 1.0){
		viewPos01.x = -1.0;
		var newViewPos01Right : Vector3 = camera.ViewportToWorldPoint(viewPos01);
		starLayer01.transform.position = newViewPos01Right;
	}
	
	else if(viewPos02.x <= -1.0){
		viewPos02.x = 1.0;
		var newViewPos02Left : Vector3 = camera.ViewportToWorldPoint(viewPos02); 
		starLayer02.transform.position = newViewPos02Left;
	}
	
	else if(viewPos02.x >= 1.0){
		viewPos02.x = -1.0;
		var newViewPos02Right : Vector3 = camera.ViewportToWorldPoint(viewPos02);
		starLayer02.transform.position = newViewPos02Right;
	}

}