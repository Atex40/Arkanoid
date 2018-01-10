using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour {

	public float score;
	public Text text_score;


	private static UI_Manager instance ;
    public static UI_Manager Instance () 
    {
        return instance;
    }
void Awake ()
    {
        if (instance != null)
        {
            Destroy (gameObject);
        }
        else 
        {
            instance = this;
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		text_score.text = score.ToString();
	}

	public void AddScore_Gris ()
	{
		score += 200;
	}

	public void AddScore_Green ()
	{
		score += 20;
	}

	public void AddScore_Pink ()
	{
		score += 40;
	}

	public void AddScore_Orange ()
	{
		score += 60;
	}
	public void AddScore_Bleue ()
	{
		score += 80;
	}

	public void AddScore_Rouge ()
	{
		score += 100;
	}
}
