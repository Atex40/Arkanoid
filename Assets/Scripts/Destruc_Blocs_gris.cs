using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruc_Blocs_gris : MonoBehaviour {

	private int bloc_gris = 3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D other)
	{
    	if (other.gameObject.CompareTag("ball"))
        {
        	bloc_gris -= 1;
        	if (bloc_gris <= 0)
            Destroy(gameObject);
        }
	}
}
