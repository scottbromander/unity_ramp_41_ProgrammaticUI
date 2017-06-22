using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIRotation : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		//Solution #1
		//transform.rotation = Camera.main.transform.rotation;

		//Solution #2
		float dotProduct = Vector3.Dot(Camera.main.transform.position - this.transform.position,
			this.transform.forward);

		if (dotProduct >= 0) {
			transform.Rotate (Vector3.up - new Vector3 (0, 180, 0));
		}
	}
}
