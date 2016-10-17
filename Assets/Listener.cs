using UnityEngine;
using System.Collections;

public class Listener : MonoBehaviour {

	public GameObject gameObjectWithEvents;

	// Use this for initialization
	void Start () {
		if (gameObjectWithEvents == null) {
			this.enabled = false;
			Debug.Log ("Must Set Game Object With Events");
		} else { 
			gameObjectWithEvents.GetComponent<Events> ().MouseLeftClick += HandleEvent;
		}
	}

	public void HandleEvent(GameObject sender, string eventMessage){
		Debug.Log (sender.name + " sent us an event: " + eventMessage);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
