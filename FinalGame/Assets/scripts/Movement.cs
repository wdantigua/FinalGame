using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	Transform player;


	MoveUp()
	{
		player.position += player.up 
	}

	MoveDown()
	{
		player.position -= player.up 
	}	

	MoveLeft()
	{
		player.position -= player.right 
	}	

	MoveRight()
	{
		player.position += player.right 
	}	

}