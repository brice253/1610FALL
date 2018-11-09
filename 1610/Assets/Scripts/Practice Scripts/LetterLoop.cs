using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterLoop : MonoBehaviour
{
	public string[] FavoriteMovies;

	void Start () 
	{
		foreach (var movie in FavoriteMovies)
		{
			print(movie);
		}
	}
	
	
}
