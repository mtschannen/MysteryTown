using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour {

	public GameObject startCanvas;
	public GameObject firstPersonController;
	// Use this for initialization
	void Start () {
		firstPersonController.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			startCanvas.SetActive (false);
			firstPersonController.SetActive (true);
		}
		if (Input.GetKeyDown("escape"))
			Application.Quit();
	}
}
