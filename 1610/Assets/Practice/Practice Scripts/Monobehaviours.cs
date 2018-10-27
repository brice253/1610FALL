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
	
	void

	private void OnMouseDown()
	{
		print("Mouse down");
	}

	private void OnMouseUp()
	{
		print("Mouse up");
	}

	private void OnEnable()
	{
		print("Enabled");
	}
}
