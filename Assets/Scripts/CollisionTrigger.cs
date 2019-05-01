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
        //Debug.Log("pow pow");
	}

	public void OnPointerClick(PointerEventData data) {
		Debug.Log("OnPointerClick");
	}

	public void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("key")) {
			Destroy(other.gameObject);
            // display info about key
            Debug.Log("Destroying key.");
        } else {
            // reach into collided object and display UI canvas 
            ClueController clue = other.GetComponent<ClueController>(); //.GetComponent<Canvas>();
            Transform canvas = clue.canvas;
            //Debug.Log(canvas.gameObject.activeInHierarchy);
            canvas.gameObject.SetActive(true);
			Debug.Log("Should show UI object");
        }
	}

    public void OnTriggerExit(Collider other) {
        // reach into collided object and display UI canvas 
        ClueController clue = other.GetComponent<ClueController>(); //.GetComponent<Canvas>();
        Transform canvas = clue.canvas;
        //Debug.Log(canvas.gameObject.activeInHierarchy);
        canvas.gameObject.SetActive(false);
        Debug.Log("Should hide UI object");

    }
}
