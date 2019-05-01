using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CollisionTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnPointerClick(PointerEventData data) {
		Debug.Log("OnPointerClick");
	}

	public void OnTriggerEnter(Collider other) {
		Destroy(other.gameObject);
		Debug.Log("OnTriggerEnter");
	}
}
