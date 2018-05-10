using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour {

	public GameObject mainCam;
	public GameObject zombie;
	Vector3 playerPosition;
	Vector3 zombiePosition;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		mainCam = GameObject.FindGameObjectWithTag("MainCamera");
		//zombie = GameObject.FindGameObjectWithTag("Zombie");
		playerPosition = mainCam.transform.position;
		//zombiePosition = zombie.transform.position;
		zombiePosition = transform.position;
		if (Vector3.Distance (playerPosition, zombiePosition) < 100f) {
			Follow ();
		}
	}

	void Follow () {
		
	}
}
