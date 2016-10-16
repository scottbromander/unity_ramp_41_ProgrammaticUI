using UnityEngine;
using System.Collections;

public delegate void CustomEvent (GameObject sender, string eventMessage);

public class Events : MonoBehaviour {

	public event CustomEvent MouseOver;
	public event CustomEvent MouseLeftClick;
	
	// Update is called once per frame
	void Update () {
		RectTransform myRect = this.GetComponent<RectTransform> ();
		Rect onScreenRect = myRect.rect;
		onScreenRect.Set (onScreenRect.x + this.transform.position.x, 
			onScreenRect.y + this.transform.position.y,
			onScreenRect.width, onScreenRect.height);

		if (onScreenRect.Contains (Input.mousePosition)) {
			if (MouseOver != null) {
				MouseOver (this.gameObject, "The mouse pointer is over me");
			}

			if (Input.GetMouseButtonDown (0)) {
				if (MouseLeftClick != null) {
					MouseLeftClick (this.gameObject, "I've been clicked!");
				}
			}
		}
	}
}
