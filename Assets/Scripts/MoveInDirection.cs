using UnityEngine;
using System.Collections;

public class MoveInDirection : MonoBehaviour {

	Vector2 direction;
	float maxRange = 5;

	// Use this for initialization
	void Start () {
		direction = new Vector2 (Random.Range (-maxRange, maxRange), Random.Range (-maxRange, maxRange));
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate (direction.x, direction.y, 0);
	}
}
