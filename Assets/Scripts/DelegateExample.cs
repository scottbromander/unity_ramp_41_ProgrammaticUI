using UnityEngine;
using System.Collections;

public class DelegateExample : MonoBehaviour {

	delegate void ExampleDelegate(int a, int b);
	ExampleDelegate methodToUse;

	void AddDelegate(int a, int b){
		Debug.Log ("Here is the sum: " + (a + b));
		methodToUse = SubtractDelegate;
	}

	void SubtractDelegate(int a, int b){
		Debug.Log ("Here is the difference: " + (a - b));
		methodToUse = AddDelegate;
	}

	void Start(){
		methodToUse = SubtractDelegate;
	}

	void Update(){
		if (Input.GetMouseButtonDown (0)) {
			methodToUse.Invoke (4, 5);
		}
	}
}
