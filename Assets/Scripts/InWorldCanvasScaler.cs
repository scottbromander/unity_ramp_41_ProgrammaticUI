using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InWorldCanvasScaler : MonoBehaviour {

	public float pixlesPerUnit = 25f;

	public void OnValidate(){
		transform.localScale = new Vector3 (
			1 / pixlesPerUnit,
			1 / pixlesPerUnit, 
			1);
	}
}
