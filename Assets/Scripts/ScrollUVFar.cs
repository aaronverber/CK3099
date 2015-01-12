using UnityEngine;
using System.Collections;

public class ScrollUVFar : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		Material mat = this.renderer.material;
		Vector2 offset = mat.mainTextureOffset;

		offset.x = transform.position.x / 300;
		offset.y = transform.position.y / 300;
		
		mat.mainTextureOffset = offset;
	}
}
