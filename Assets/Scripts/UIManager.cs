using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

	Canvas baseCanvas;

	// Use this for initialization
	void Start () {
		GameObject canvas = new GameObject ("Canvas");
		baseCanvas = canvas.AddComponent<Canvas> ();
		baseCanvas.renderMode = RenderMode.ScreenSpaceOverlay;

		canvas.AddComponent<CanvasScaler> ();

		canvas.AddComponent<GraphicRaycaster> (); //allows UI to understand mouse events

		GameObject eventSystem = new GameObject ("EventSystem");
		eventSystem.AddComponent<UnityEngine.EventSystems.EventSystem> ();
		eventSystem.AddComponent<UnityEngine.EventSystems.StandaloneInputModule> ();

		CreateSprite ("Star");
	}

	void CreateSprite(string spriteName) {
		GameObject sprite = new GameObject (spriteName);
		Sprite mySprite = Resources.Load<Sprite> (spriteName);

		Image spriteImage = sprite.AddComponent<Image> ();
		spriteImage.sprite = mySprite;

		sprite.transform.SetParent (baseCanvas.transform);

		RectTransform rectTransform = sprite.GetComponent<RectTransform> ();

		Vector3 position = new Vector3 (50, 50, 0);
		rectTransform.position = position;
	}
}
