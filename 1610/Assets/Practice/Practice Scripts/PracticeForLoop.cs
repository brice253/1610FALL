using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeForLoop : MonoBehaviour
{

	public string Word;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < Word.Length; i++)
		{
			print(Word[i]);
		}
	}
	
}
