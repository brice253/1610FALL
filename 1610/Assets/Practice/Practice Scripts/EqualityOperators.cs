using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EqualityOperators : MonoBehaviour
{

	public int Apples;
	public int Bananas;

	private void Update()
	{
		if (Apples == Bananas)
		{
			print("Same amount of apples and bananas");
		}

		if (Apples > Bananas)
		{
			print("You have more apples");
		}

		if (Apples < Bananas)
		{
			print("you have more bananas");
		}
		
		if (Apples != Bananas)
		{
			print("The amount of apples and bananas is not equal");
		}
		
	}
}
