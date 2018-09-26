using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadBoom : MonoBehaviour {

    public Vector3 Explosion;
	
	// Update is called once per frame
	void Update () 
    {
        transform.Translate(Explosion);
	}
}
