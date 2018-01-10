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

	void OnCollisionEnter2D (Collision2D other)
	{
		if (other.gameObject.CompareTag("ball"))
		{
           	Destroy(gameObject);
           	UI_Manager.Instance().AddScore_Green();
		}
	}

/*	void Score_Color ()
	{
		if (GameObject.gameObject.Tag("green"))
		{
			UI_Manager.Instance().AddScore_Green();
		}

		if (GameObject.gameObject.Tag("pink"))
		{
			UI_Manager.Instance().AddScore_Pink();
		}

		if (GameObject.gameObject.Tag("orange"))
		{
			UI_Manager.Instance().AddScore_Orange();
		}

		if (GameObject.gameObject.Tag("blue"))
		{
			UI_Manager.Instance().AddScore_Blue();
		}

		if (GameObject.gameObject.Tag("red"))
		{
			UI_Manager.Instance().AddScore_Red();
		}
	}*/
}
