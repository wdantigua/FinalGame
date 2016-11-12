using UnityEngine;
using System.Collections;

public static class Movement : MonoBehaviour {

	Transform player;

	Movement()
	{
		
	}

	void  MoveUp()
	{
		 player.position += player.up; 
	}

	void MoveDown()
	{
		player.position -= player.up ;
	}	

	void MoveLeft()
	{
		player.position -= player.right ;
	}	

	void MoveRight()
	{
		player.position += player.right ;
	}	

}