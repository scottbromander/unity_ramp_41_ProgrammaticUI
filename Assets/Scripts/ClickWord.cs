using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ClickWord : MonoBehaviour {

	public List<GameObject> hitEffects = new List<GameObject> ();

	// Use this for initialization
	void Start () {
		if (hitEffects.Count < 1) {
			Debug.Log ("You must add at least one effect!");
			this.enabled = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			Vector3 clickPosition = Input.mousePosition;
			GameObject wordObject = Instantiate (hitEffects[Random.Range(0, hitEffects.Count)], clickPosition, Quaternion.identity) as GameObject;
			wordObject.transform.SetParent (this.transform);
		}
	}
}
