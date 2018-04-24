using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour {

	public GameObject startCanvas;
	public GameObject firstPersonController;
	public Camera firstPersonCamera;
	public Camera mapCamera;
	public GameObject locationMarker;
	// Use this for initialization
	void Start () {
		firstPersonController.SetActive (false);
		locationMarker.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			startCanvas.SetActive (false);
			firstPersonController.SetActive (true);
		}
		if (Input.GetKeyDown("escape"))
			Application.Quit();
		
		if (Input.GetKeyDown ("m")) {
			if (mapCamera.enabled == false) {
				firstPersonCamera.enabled = false;
				mapCamera.enabled = true;
				locationMarker.SetActive (true);
			} else {
				mapCamera.enabled = false;
				firstPersonCamera.enabled = true;
				locationMarker.SetActive (false);
			}
		}
	}
}
