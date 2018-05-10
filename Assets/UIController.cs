using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

	public GameObject startCanvas;
	public GameObject firstPersonController;
	public Camera firstPersonCamera;
	public Camera mapCamera;
	public GameObject locationMarker;
    public GameObject objective1;
	public GameObject objective2;
	public GameObject objective3;
//	public GameObject objective4;
//	public GameObject objective5;
//	public GameObject objective6;
//	public GameObject objective7;
	public GameObject dialogueBox;
	public Text dialogueText;

	// Use this for initialization
	void Start () {
		firstPersonController.SetActive (false);
		locationMarker.SetActive (false);
		dialogueBox.SetActive(false);
		mapCamera.enabled = false;
		firstPersonCamera.enabled = true;
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

        if (firstPersonController)
        {
            float dist1 = Vector3.Distance(firstPersonCamera.transform.position, objective1.transform.position);
			float dist2 = Vector3.Distance(firstPersonCamera.transform.position, objective2.transform.position);
			float dist3 = Vector3.Distance(firstPersonCamera.transform.position, objective3.transform.position);
//			float dist4 = Vector3.Distance(firstPersonCamera.transform.position, objective4.transform.position);
//			float dist5 = Vector3.Distance(firstPersonCamera.transform.position, objective5.transform.position);
//			float dist6 = Vector3.Distance(firstPersonCamera.transform.position, objective6.transform.position);
//			float dist7 = Vector3.Distance(firstPersonCamera.transform.position, objective7.transform.position);
            if(dist1 <= 25)
            {
				dialogueBox.SetActive(true);
				dialogueText.text = "Objective 1 Nearby";
            } 
			else if(dist2 <= 25){
				dialogueBox.SetActive(true);
				dialogueText.text = "Objective 2 Nearby";
			}
			else if(dist3 <= 25){
				dialogueBox.SetActive(true);
				dialogueText.text = "Objective 3 Nearby";
			}
//			else if(dist4 <= 25){
//				dialogueBox.SetActive(true);
//				dialogueText.text = "Objective 4 Nearby";
//			}
//			else if(dist5 <= 25){
//				dialogueBox.SetActive(true);
//				dialogueText.text = "Objective 5 Nearby";
//			}
//			else if(dist6 <= 25){
//				dialogueBox.SetActive(true);
//				dialogueText.text = "Objective 6 Nearby";
//			}
//			else if(dist7 <= 25){
//				dialogueBox.SetActive(true);
//				dialogueText.text = "Objective 7 Nearby";
//			}
            else
            {
				dialogueBox.SetActive(false);
            }
        }
	}
}
