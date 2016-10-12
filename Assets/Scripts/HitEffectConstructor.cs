using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HitEffectConstructor : MonoBehaviour {

	public Sprite spriteToUse;
	public bool hasRandomMovement;
	public float decayTime;

	// Use this for initialization
	void Start () {
		Decay decayScript = GetComponent<Decay> ();
		if (decayScript != null) {
			decayScript.decaySeconds = decayTime;
		}

		if (hasRandomMovement) {
			this.gameObject.AddComponent<MoveInDirection> ();
		}

		Image imageScript = this.GetComponent<Image> ();
		imageScript.sprite = spriteToUse;
	}
}
