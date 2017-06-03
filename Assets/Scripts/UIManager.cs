using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

	public static UIManager instance;
	Canvas baseCanvas;
	public float imageSize = 50;

	// Use this for initialization
	void Start () {
		if (UIManager.instance != null) {
			Debug.Log ("Only one instance of UIManager allowed");
			this.enabled = false;
			return;
		}

		UIManager.instance = this;

		GameObject canvas = new GameObject ("Canvas");
		baseCanvas = canvas.AddComponent<Canvas> ();
		baseCanvas.renderMode = RenderMode.ScreenSpaceOverlay;

		canvas.AddComponent<CanvasScaler> ();

		canvas.AddComponent<GraphicRaycaster> (); //allows UI to understand mouse events

		GameObject eventSystem = new GameObject ("EventSystem");
		eventSystem.AddComponent<UnityEngine.EventSystems.EventSystem> ();
		eventSystem.AddComponent<UnityEngine.EventSystems.StandaloneInputModule> ();

		CreateSprite (new Vector3(0,0,0), "Star");
	}

	public GameObject CreateSprite(Vector3 position, string spriteName) {
		GameObject sprite = new GameObject (spriteName);
		Sprite mySprite = Resources.Load<Sprite> (spriteName);

		Image spriteImage = sprite.AddComponent<Image> ();
		spriteImage.sprite = mySprite;

		sprite.transform.SetParent (baseCanvas.transform);

		RectTransform rectTransform = sprite.GetComponent<RectTransform> ();

		float imageSize = 100;

		rectTransform.SetInsetAndSizeFromParentEdge (
			RectTransform.Edge.Right,
			position.x,
			imageSize
		);
		rectTransform.SetInsetAndSizeFromParentEdge (
			RectTransform.Edge.Bottom,
			position.y,
			imageSize
		);

	}
}
