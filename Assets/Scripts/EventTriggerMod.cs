using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class EventTriggerMod : MonoBehaviour {

	public delegate void EventDelegate(BaseEventData eventDate);

	public void EventMethod(BaseEventData baseEvent){
		Debug.Log(((PointerEventData)baseEvent).pointerEnter.name + " triggered the event");
	}

	// Use this for initialization
	void Start () {
		//Added on the component itself, on the button, component called Event Trigger
		EventTrigger eventTrigger = this.GetComponent<EventTrigger> ();

		EventTrigger.Entry entry = new EventTrigger.Entry ();

		entry.eventID = EventTriggerType.PointerEnter;

		entry.callback = new EventTrigger.TriggerEvent ();

		UnityAction<BaseEventData> callback = new UnityAction<BaseEventData> (EventMethod);

		entry.callback.AddListener (callback);

		eventTrigger.triggers.Add (entry);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
