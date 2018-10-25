using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeLoops : MonoBehaviour
{

	public string[] Food;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < Food.Length; i++)
		{
			print(Food[i]);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
