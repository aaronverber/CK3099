#pragma strict

function Update () {
	var mat = this.renderer.material;
	var offset : Vector2 = mat.mainTextureOffset;
	
	
	offset.x = transform.position.x / 300;
	offset.y = transform.position.y / 300;
	
	mat.mainTextureOffset = offset;
}