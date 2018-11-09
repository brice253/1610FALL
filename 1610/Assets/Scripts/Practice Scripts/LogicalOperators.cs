using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicalOperators : MonoBehaviour
{

	public bool FoodReady;
	public bool LightOn;


	// Update is called once per frame
	void Update () 
	{
		if (FoodReady && LightOn) // "&&" means both have to be true
		{
			print("Food is ready and light is on.");
		}

		if (FoodReady || LightOn) // "||" means only one needs to be true
		{
			print("Either food is ready or light is on.");
		}
 	}
}
