using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Hole : MonoBehaviour {


void Start() {

}
	static public bool holeMet = false;

	void OnTriggerEnter(Collider other) {
	
		if (other.gameObject.CompareTag("Ball")) {
			
			Hole.holeMet = true;

			other.gameObject.SetActive (false);



		}
	}

    void Update()
    {
        
    }
}
