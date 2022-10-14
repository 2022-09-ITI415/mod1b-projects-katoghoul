using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Hole : MonoBehaviour {

[Header("Set Dynamically")]
public text scoreGT; // a
void Start() {

GameObject scoreGO = GameObject.Find("LevelCounter"); 

scoreGT = scoreGO.GetComponent<Text>(); 

scoreGT.text = "0";
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
