﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

	public GameObject startCanvas;
	public GameObject firstPersonController;
	public Camera firstPersonCamera;
	public Camera mapCamera;
	public GameObject locationMarker;
	public int objectiveCount = 0;
	public GameObject boat;
	public GameObject objective1;
	public GameObject objective2;
	public GameObject objective3;
	public GameObject objective4;
	public GameObject objective5;
	public GameObject objective6;
	public GameObject objective7;
	public GameObject objective1Loaded;
	public GameObject objective2Loaded;
	public GameObject objective3Loaded;
	public GameObject objective4Loaded;
	public GameObject objective5Loaded;
	public GameObject objective6Loaded;
	public GameObject objective7Loaded;
	public GameObject dialogueBox;
	public GameObject progressBox;
	public GameObject endGameBox;
	public Text dialogueText;
	public Text progressText;
	public Text timeText;
	public float startTime;
	public float elapsedTime;
	//private GUIStyle guiStyle = new GUIStyle();

	// Use this for initialization
	void Start () {
		firstPersonController.SetActive (false);
		locationMarker.SetActive (false);
		dialogueBox.SetActive(false);
		mapCamera.enabled = false;
		firstPersonCamera.enabled = true;
		progressBox.SetActive (false);
		startTime = 0;
		elapsedTime = 0;
	}
	
	// Update is called once per frame
	void Update () {

		if (objectiveCount < 7) {
			progressText.text = "Supplies needed: " + (7 - objectiveCount).ToString ();
		} else {
			progressText.text = "Get to the boat!";
		}
		if (Input.GetKeyDown ("space") && startTime == 0) {
			startCanvas.SetActive (false);
			firstPersonController.SetActive (true);
			progressBox.SetActive (true);
			startTime = Time.time;
		}
		if (startTime != 0) {
			elapsedTime = Time.time - startTime;
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
			float distBoat = Vector3.Distance(firstPersonCamera.transform.position, boat.transform.position);
            float dist1 = Vector3.Distance(firstPersonCamera.transform.position, objective1.transform.position);
			float dist2 = Vector3.Distance(firstPersonCamera.transform.position, objective2.transform.position);
			float dist3 = Vector3.Distance(firstPersonCamera.transform.position, objective3.transform.position);
			float dist4 = Vector3.Distance(firstPersonCamera.transform.position, objective4.transform.position);
			float dist5 = Vector3.Distance(firstPersonCamera.transform.position, objective5.transform.position);
			float dist6 = Vector3.Distance(firstPersonCamera.transform.position, objective6.transform.position);
			float dist7 = Vector3.Distance(firstPersonCamera.transform.position, objective7.transform.position);
			if(distBoat <= 10){
				dialogueBox.SetActive(true);
				dialogueText.text = "You must collect more resources before you can leave!";
				if (objectiveCount >= 7) {
					dialogueText.text = "You have enough resources, press E to cast off!";
					if (Input.GetKeyDown ("e")) {
						timeText.text = "Your time: " + elapsedTime;
						endGameBox.SetActive (true);
						progressBox.SetActive (false);
						dialogueBox.SetActive (false);
						firstPersonController.SetActive (false);
						startTime = 0;
					}
				}
			}
			else if(dist1 <= 15 && objective1.activeInHierarchy == true)
            {
				dialogueBox.SetActive(true);
				dialogueText.text = "Supplies nearby.";
				if (dist1 <= 2.5) {
					dialogueText.text = "Press E to collect resource.";
					if (Input.GetKeyDown ("e")) {
						objective1.SetActive (false);
						objective1Loaded.SetActive (true);
						objectiveCount++;
					}
				}
            } 
			else if(dist2 <= 15 && objective2.activeInHierarchy == true){
				dialogueBox.SetActive(true);
				dialogueText.text = "Supplies nearby.";
				if (dist2 <= 2.5) {
					dialogueText.text = "Press E to collect resource.";
					if (Input.GetKeyDown ("e")) {
						objective2.SetActive (false);
						objective2Loaded.SetActive (true);
						objectiveCount++;
					}
				}
			}
			else if(dist3 <= 15 && objective3.activeInHierarchy == true){
				dialogueBox.SetActive(true);
				dialogueText.text = "Supplies nearby.";
				if (dist3 <= 2.5) {
					dialogueText.text = "Press E to collect resource.";
					if (Input.GetKeyDown ("e")) {
						objective3.SetActive (false);
						objective3Loaded.SetActive (true);
						objectiveCount++;
					}
				}
			}
			else if(dist4 <= 15 && objective4.activeInHierarchy == true){
				dialogueBox.SetActive(true);
				dialogueText.text = "Supplies nearby.";
				if (dist4 <= 2.5) {
					dialogueText.text = "Press E to collect resource.";
					if (Input.GetKeyDown ("e")) {
						objective4.SetActive (false);
						objective4Loaded.SetActive (true);
						objectiveCount++;
					}
				}
			}
			else if(dist5 <= 15 && objective5.activeInHierarchy == true){
				dialogueBox.SetActive(true);
				dialogueText.text = "Supplies nearby.";
				if (dist5 <= 2.5) {
					dialogueText.text = "Press E to collect resource.";
					if (Input.GetKeyDown ("e")) {
						objective5.SetActive (false);
						objective5Loaded.SetActive (true);
						objectiveCount++;
					}
				}
			}
			else if(dist6 <= 15 && objective6.activeInHierarchy == true){
				dialogueBox.SetActive(true);
				dialogueText.text = "Supplies nearby.";
				if (dist6 <= 2.5) {
					dialogueText.text = "Press E to collect resource.";
					if (Input.GetKeyDown ("e")) {
						objective6.SetActive (false);
						objective6Loaded.SetActive (true);
						objectiveCount++;
					}
				}
			}
			else if(dist7 <= 15 && objective7.activeInHierarchy == true){
				dialogueBox.SetActive(true);
				dialogueText.text = "Supplies nearby.";
				if (dist7 <= 2.5) {
					dialogueText.text = "Press E to collect resource.";
					if (Input.GetKeyDown ("e")) {
						objective7.SetActive (false);
						objective7Loaded.SetActive (true);
						objectiveCount++;
					}
				}
			}
            else
            {
				dialogueBox.SetActive(false);
            }
        }
			
	}

	void OnGUI() {
		GUI.Label (new Rect (10, 10, 200, 100), Mathf.Round(elapsedTime).ToString());
	}

}
