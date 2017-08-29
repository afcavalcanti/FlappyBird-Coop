using UnityEngine;
using System.Collections;

public class Column : MonoBehaviour 
{

	private int cont = 0;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player1")
			cont++;
		if (other.tag == "Player1")
			cont++;
		if(cont == 2)
		{
			//If the both birds hits the trigger collider in between the columns then
			//tell the game control that scored.
			GameControl.instance.BirdScored();
		}
		cont = 0;
	}
}