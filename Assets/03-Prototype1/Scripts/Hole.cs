using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Hole : MonoBehaviour {

[Header("Set in Inspector")]
public GameObject LevelEnd;


void Start() {
	
	LevelEnd.SetActive(false);
	
}	static public bool holeMet = false;
	
	void OnTriggerEnter(Collider other) {
	
		if (other.gameObject.CompareTag("Ball")) {
			
			Hole.holeMet = true;

			other.gameObject.SetActive (false);
		LevelEnd.SetActive(true);}

		
    void Update()
    {
        
    }
}}
