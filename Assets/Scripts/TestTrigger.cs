using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TestTrigger : EventTrigger {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public override void OnPointerClick(PointerEventData data) {
		Debug.Log("OnPointerClick");
	}

	public void OnTriggerEnter(Collider other) {
		Debug.Log("OnTriggerEnter");
	}
}
