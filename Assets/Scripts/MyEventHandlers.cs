using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class MyEventHandlers : MonoBehaviour, IPointerEnterHandler, IDragHandler, IPointerExitHandler {

	private bool pulse = false;
	private float time = 0;

	public void OnDrag(PointerEventData eventData) {
		
	}

	public void OnPointerEnter(PointerEventData eventData) {

	}

	public void OnPointerExit(PointerEventData eventData) {

	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
