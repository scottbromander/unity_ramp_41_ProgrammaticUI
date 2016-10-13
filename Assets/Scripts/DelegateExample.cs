using UnityEngine;
using System.Collections;

public class DelegateExample : MonoBehaviour {

	delegate void ExampleDelegate();

	void ThisIsADelegate(){
		Debug.Log ("Here we are!");
	}

	// Use this for initialization
	void Start () {
		ExampleDelegate methodToUse = ThisIsADelegate;

		methodToUse.Invoke ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
