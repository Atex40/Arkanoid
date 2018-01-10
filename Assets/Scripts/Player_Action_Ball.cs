using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Action_Ball : MonoBehaviour {

    public KeyCode launchKey;
    public float ejectionSpeed;
    public float maxSpeed;
    public Rigidbody2D ballRb;
    public Transform player;

    private bool isLauch = false;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(!isLauch)
        {
            transform.position = new Vector2(player.position.x,player.position.y+1);
        }

		if(Input.GetKeyDown(launchKey) && !isLauch)
        {
            ballRb.AddForce(Vector2.up * ejectionSpeed, ForceMode2D.Impulse);
            this.transform.parent = null;
           
            Debug.Log(isLauch);
            isLauch = true;
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
