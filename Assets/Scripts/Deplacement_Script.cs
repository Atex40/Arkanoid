﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deplacement_Script : MonoBehaviour {

    private Rigidbody2D rb;

    public float speed;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(moveHorizontal, 0.0f);

        rb.velocity = new Vector2(moveHorizontal * speed, 0);
    }
}
