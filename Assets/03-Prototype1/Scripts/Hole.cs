using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
	static public bool holeMet = false;

	void OnTriggerEnter(Collider other) {
	
		if (other.gameObject.CompareTag("Ball")) {
			
			Hole.holeMet = true;

			other.gameObject.SetActive (false);

			Material mat = GetComponent<Renderer>().material;
			Color c = mat.color;
			c.a = 1;
			mat.color = c;
		}
	}

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
