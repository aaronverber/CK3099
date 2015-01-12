using UnityEngine;
using System.Collections;

public class ScrollUVClose : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		Material mat = this.renderer.material;
		Vector2 offset = mat.mainTextureOffset;

		offset.x = transform.position.x / 200;
		offset.y = transform.position.y / 200;
		
		mat.mainTextureOffset = -(offset);
	}
}
