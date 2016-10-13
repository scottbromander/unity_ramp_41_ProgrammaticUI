using UnityEngine;
using System.Collections;

public class DelegateExample : MonoBehaviour {

	delegate void ExampleDelegate();

	void ThisIsADelegate(){
		Debug.Log ("Here we are!");
	}

	void ThisIsAnotherDelete(){
		Debug.Log ("BOOM! Reassigned!");
	}

	// Use this for initialization
	void Start () {
		ExampleDelegate methodToUse = ThisIsAnotherDelete;

		methodToUse.Invoke ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
