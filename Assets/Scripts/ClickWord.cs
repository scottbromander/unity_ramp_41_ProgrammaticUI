using UnityEngine;
using System.Collections;

public class ClickWord : MonoBehaviour {

	public GameObject wordPrefab;

	// Use this for initialization
	void Start () {
		if (wordPrefab == null) {
			Debug.Log ("You must the Word Prefab");
			this.enabled = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			Vector3 clickPosition = Input.mousePosition;
			GameObject wordObject = Instantiate (wordPrefab, clickPosition, Quaternion.identity) as GameObject;
			wordObject.transform.SetParent (this.transform);
		}
	}
}
