using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Decay : MonoBehaviour {

	public float decaySeconds = 1f;
	float elapsedSeconds = 0;
	Image uiImage;

	// Use this for initialization
	void Start () {
		uiImage = GetComponent<Image> ();
		Destroy (this.gameObject, decaySeconds);
	}
	
	// Update is called once per frame
	void Update () {
		uiImage.color = new Color (uiImage.color.r, uiImage.color.g, uiImage.color.b, ((decaySeconds - elapsedSeconds) / decaySeconds));
		elapsedSeconds += Time.deltaTime;
	}
}
