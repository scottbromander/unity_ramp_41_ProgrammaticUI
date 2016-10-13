using UnityEngine;
using System.Collections;

public class DelegateExample : MonoBehaviour {

	delegate void ExampleDelegate(int a, int b);

	void AddDelegate(int a, int b){
		Debug.Log ("Here is the sum: " + (a + b));
	}

	void SubtractDelegate(int a, int b){
		Debug.Log ("Here is the difference: " + (a - b));
	}

	void Start(){
		ExampleDelegate methodToUse = SubtractDelegate;
		methodToUse.Invoke (4, 5);
	}
}
