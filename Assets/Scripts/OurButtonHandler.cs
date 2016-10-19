using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OurButtonHandler : MonoBehaviour {



	// Use this for initialization
	void Start () {
		Button button = this.GetComponent<Button> ();
		button.onClick.RemoveAllListeners ();
		button.onClick.AddListener (()=> HandleButton(button));
	}

	void HandleButton(Button button){
		button.GetComponent<Image> ().color = Color.red;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
