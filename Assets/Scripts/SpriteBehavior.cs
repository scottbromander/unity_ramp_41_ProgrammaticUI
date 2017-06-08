using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SpriteBehavior : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler {

	Vector3 initialPosition;
	GameObject draggingElement;

	public void OnBeginDrag(PointerEventData eventData){
		initialPosition = this.transform.position;
		this.GetComponent<Image>().color = Color.gray;
		draggingElement = UIManager.instance.CreateSprite (initialPosition, this.gameObject.name);
	}

	public void OnDrag(PointerEventData eventData){
		if (draggingElement != null) {
			draggingElement.transform.position = Input.mousePosition;
		}
	}

	public void OnEndDrag(PointerEventData eventData){
		float imageSize = UIManager.instance.imageSize;

		if ((Input.GetKey (KeyCode.LeftControl) || Input.GetKey (KeyCode.RightControl))) {

		}
	}
}
