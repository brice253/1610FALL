using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monobehaviours : MonoBehaviour {
	private void Awake()
	{
		print("Awake");
	}

	// Use this for initialization
	void Start () {
		print("something");
		
	}
	
	// Update is called once per frame
	void Update () {
		print("Update");
	}

	private void OnMouseUp()
	{
		print("Mouse up");
	}

	private void OnMouseDown()
	{
		print("Mouse down");
	}

	private void OnEnable()
	{
		print("Enabled");
	}

	private void OnBecameInvisible()
	{
		print("Where is the moon?");
	}

	private void OnBecameVisible()
	{
		print("The moon is back!");
	}
}
