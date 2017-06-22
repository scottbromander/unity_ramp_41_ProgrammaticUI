using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisableRange : MonoBehaviour {

	CanvasGroup canvasGroup;
	public float visableDistance = 5f;

	// Use this for initialization
	void Start () {
		canvasGroup = this.GetComponent<CanvasGroup> ();
	}
	
	// Update is called once per frame
	void Update () {
		float distance = (this.transform.position - Camera.main.transform.position).magnitude;
		float alpha = visableDistance - distance;

		canvasGroup.alpha = Mathf.Clamp (alpha, 0, 1);
	}
}
