using UnityEngine;
using System.Collections;

public class InstanceObject : MonoBehaviour 
{

    public GameObject Instance;

    void Update () 
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(Instance, transform.position, transform.rotation);

        }
	}
}
