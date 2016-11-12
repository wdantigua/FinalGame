using UnityEngine;
using System.Collections;

public class Controller : Movement {
	
	// Use this for initialization
	void Start () {
		speed = 390;
		base.Start (); // Start from Movement
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey (KeyCode.UpArrow)) 

		{
			MoveUp();
		}

		if (Input.GetKey (KeyCode.DownArrow)) 

		{

		}

		if (Input.GetKey (KeyCode.LeftArrow)) 

		{

		}

		if (Input.GetKey (KeyCode.RightArrow)) 

		{

		}

		if (Input.GetKey (KeyCode.A)) 

		{

		}

		if (Input.GetKey (KeyCode.S)) 

		{

		}

		if (Input.GetKey (KeyCode.D)) 

		{

		}



	}
}
