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

	}

	void CreateSprite() {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
