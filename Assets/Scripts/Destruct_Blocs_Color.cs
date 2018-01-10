using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruct_Blocs_Color : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggEnter2D (Collider other)
	{
		if (other.gameObject.CompareTag("ball"))
           	Destroy(other.gameObject);
	}
}
