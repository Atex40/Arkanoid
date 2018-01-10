using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Action_Ball : MonoBehaviour {

    public KeyCode launchKey;
    public float ejectionSpeed;
    public float maxSpeed;
    public Rigidbody2D ballRb;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKeyDown(launchKey))
        {
            ballRb.AddForce(Vector2.up * ejectionSpeed, ForceMode2D.Impulse);
        }
	}

    private void FixedUpdate()
    {
        if(ballRb.velocity.y > maxSpeed)
        {
            ballRb.velocity = new Vector2(maxSpeed,maxSpeed);
            //Debug.Log(ballRb.velocity);
        }
    }
}
